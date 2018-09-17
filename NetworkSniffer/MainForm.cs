using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;
using Sniffer.Model;
using System.Windows.Forms.DataVisualization.Charting;
using NetworkSniffer.Model;
using PacketDotNet.Ieee80211;

namespace NetworkSniffer
{
    public partial class MainForm : Form
    {
        private static List<RawCapture> _pacoteFila = new List<RawCapture>();
        private NetworkInterface _networkInterface;
        private Demonstration _demonstration;
        private BindingList<MyPacket> bindinglistPrincipal;
        private BindingList<Transmission> bindinglistTransmission;
        private BindingSource sourcePrincipal;
        private BindingSource sourceTransmission;

        /* 
         * Constructor
         */
        public MainForm()
        {
            InitializeComponent();

            LoadNetworkInterfaces();

            _demonstration = new Demonstration();

            //bind da lista do grid principal
            bindinglistPrincipal = new BindingList<MyPacket>(_demonstration.AllPackets);
            sourcePrincipal = new BindingSource(bindinglistPrincipal, null);
            dataGridPacotes.DataSource = sourcePrincipal;

            //bind da lista de tranmissao
            bindinglistTransmission = new BindingList<Transmission>(_demonstration.AllOpenedTransmissions);
            sourceTransmission = new BindingSource(bindinglistTransmission, null);
            dataGridTransmissao.DataSource = sourceTransmission;
        }

        /* 
         * Load network interfaces found in the computer
         */
        private void LoadNetworkInterfaces()
        {
            if (CaptureDeviceList.Instance.Count > 1)
            {
                foreach (ICaptureDevice dev in CaptureDeviceList.Instance)
                {
                    string nome = ((SharpPcap.LibPcap.PcapDevice)dev).Interface.FriendlyName;
                    this.cbNetworkInterface.Items.Add(new NetworkInterface(nome, dev));
                }
            }
        }

        /* 
         * Select a network interface
         */
        private void cbNetworkInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            _networkInterface = (NetworkInterface)cbNetworkInterface.SelectedItem;
        }

        /* 
         * Starts capture of packets in network, been captured through the network interface
         */
        private void btStartCapture_Click(object sender, EventArgs e)
        {
            if (this.cbNetworkInterface.SelectedItem == null)
            {
                MessageBox.Show("Select a network interface.");
                return;
            }

            _pacoteFila = new List<RawCapture>();
            

            try
            {
                _networkInterface.Device.OnPacketArrival += (RecebimentoPacote);
                _networkInterface.Device.Open();
                _networkInterface.Device.StartCapture();

                btIniciar.Enabled = false;
                btEncerrar.Enabled = true;
                cbNetworkInterface.Enabled = false;
                imgBusy.Visible = true;
            }
            catch
            {
                _networkInterface.Device.Close();
            }
        }

        /* 
         * Stops capture of packets
         */
        private void btEncerrar_Click(object sender, EventArgs e)
        {
            _networkInterface.Device.Close();

            EndOfCapture();

            sourcePrincipal.ResetBindings(true);
            sourceTransmission.ResetBindings(true);

            btIniciar.Enabled = true;
            btEncerrar.Enabled = false;
            cbNetworkInterface.Enabled = true;
            imgBusy.Visible = false;
        }

        /* 
         * Captures the packet and adds to the stack
         */
        private void RecebimentoPacote(object sender, CaptureEventArgs e)
        {
            _pacoteFila.Add(e.Packet);
        }

        /* 
         * Identify if the packet is cript (SSL/TSL)
         */
        private bool isCripto(String protocolo, Packet pacote)
        {
            int tamHeader = 0;
            var ipPacket = (IPPacket) pacote.Extract(typeof(IPPacket));

            if (protocolo.Equals("UDP"))
            {
                var pacoteConvert = (UdpPacket)(ipPacket.PayloadPacket);
                tamHeader = pacoteConvert.HeaderData.Count();

                if ((pacoteConvert.Bytes[tamHeader] >= 20) && (pacoteConvert.Bytes[tamHeader] <= 23))
                {
                    return true;
                }
            }

            if (protocolo.Equals("TCP"))
            {
                var pacoteConvert = (TcpPacket)(ipPacket.PayloadPacket);
                var dataOffset = (pacoteConvert.HeaderData[12] & 0xF0) >> 4;

                tamHeader = dataOffset * 4;

                if ((pacoteConvert.Bytes[tamHeader] >= 20) && (pacoteConvert.Bytes[tamHeader] <= 23))
                {
                    return true;
                }
            }

            return false;
        }

        /* 
         * Recognizes the transmissions
         */
        private void EndOfCapture()
        {
            _demonstration.LimpaListas();

            try
            {
                // Pacotes Capturados
                foreach (var packet in _pacoteFila)
                {
                    var packet1 = Packet.ParsePacket(packet.LinkLayerType, packet.Data);
                    var ipPacket = (IPPacket)packet1.Extract(typeof(IPPacket));

                    try
                    {
                        var pacote = new MyPacket();
                        pacote.ID = _demonstration.AllPackets.Count + 1;
                        pacote.Protocol = ipPacket.Protocol.ToString();
                        pacote.AddressInitial = ipPacket.SourceAddress.ToString();
                        pacote.AddressFinal = ipPacket.DestinationAddress.ToString();
                        pacote.Packet = packet1;
                        pacote.IsCript = isCripto(ipPacket.NextHeader.ToString(), pacote.Packet);

                        // Para protocolo UDP
                        if (ipPacket.NextHeader.ToString() == "UDP")
                        {
                            pacote.PortInitial = ((UdpPacket)(ipPacket.PayloadPacket)).SourcePort.ToString();
                            pacote.PortFinal = ((UdpPacket)(ipPacket.PayloadPacket)).DestinationPort.ToString();

                            // Salva os dados do pacote, em pacote.Conteudo
                            var bytesHeader = ((UdpPacket)(ipPacket.PayloadPacket)).HeaderData.Count();
                            var cont = 0;
                            foreach (var bytezinho in ((UdpPacket)(ipPacket.PayloadPacket)).Bytes)
                            {
                                if (cont >= bytesHeader)
                                    pacote.Content = pacote.Content + (char)bytezinho;
                                cont++;
                            }
                        }

                        // Para protocolo TCP
                        if (ipPacket.NextHeader.ToString() == "TCP")
                        {
                            pacote.PortInitial = ((TcpPacket)(ipPacket.PayloadPacket)).SourcePort.ToString();
                            pacote.PortFinal = ((TcpPacket)(ipPacket.PayloadPacket)).DestinationPort.ToString();

                            // Salva os dados do pacote, em pacote.Conteudo
                            var dataOffset = (((TcpPacket)(ipPacket.PayloadPacket)).DataOffset);
                            var bytesHeader = dataOffset * 4;
                            var cont = 0;
                            foreach (var bytezinho in ((TcpPacket)(ipPacket.PayloadPacket)).Bytes)
                            {
                                if (cont >= bytesHeader)
                                    pacote.Content = pacote.Content + (char)bytezinho;
                                cont++;
                            }
                        }

                        // Adiciona na lista de pacotes (mostrado no grid principal de pacotes)
                        _demonstration.AllPackets.Add(pacote);

                        var t = new Transmission();
                        t.ID = _demonstration.AllTransmissions.Count + 1;
                        t.AddressInitial = pacote.AddressInitial;
                        t.PortInitial = pacote.PortInitial;
                        t.AddressFinal = pacote.AddressFinal;
                        t.PortFinal = pacote.PortFinal;
                        t.IsCript = pacote.IsCript;

                        // Verifica se existe alguma Transmissão na ListaTransmission, em que os Enderecos Origem/Destino e 
                        // Portas Origem/Destino são as mesmas
                        if (!_demonstration.AllTransmissions.Contains(t))
                        {
                            _demonstration.AllTransmissions.Add(t);

                            // Se a transmissão não for criptografada
                            if (!t.IsCript)
                                _demonstration.AllOpenedTransmissions.Add(t);
                        }

                        // Adiciona o pacote na listaPacotes do objeto Transmissão
                        _demonstration.AllTransmissions.First(x => x.Equals(t)).Packets.Add(pacote);

                    }
                    catch
                    { }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
            }

            LoadGraphs();
        }

        /* 
         * Load statistics and draw the graph of transmissions
         */
        private void LoadGraphs()
        {
            LoadSummaries();
            DrawGraphics();
        }

        /* 
         * Load statistics and subtitles
         */
        private void LoadSummaries()
        {
            _demonstration.NumberTransmissions = _demonstration.AllTransmissions.Count;
            _demonstration.NumberCriptTransmissions = _demonstration.AllTransmissions.Count(x => x.IsCript == true);
            _demonstration.NumberOpenedTransmissions = _demonstration.AllTransmissions.Count(x => x.IsCript == false);

            lbAbertas.Text = "Opened: " + _demonstration.NumberOpenedTransmissions;
            lbCripto.Text = "Cript: " + _demonstration.NumberCriptTransmissions;
            lbTotal.Text = "Total: " + _demonstration.NumberTransmissions;
        }

        /* 
         * Draw the transmission graphs, subtitles and labels
         */
        private void DrawGraphics()
        {
            // Array de dados
            var listaLegendas = new List<String>();
            listaLegendas.Add("Cript");
            listaLegendas.Add("Opened");

            var listaValores = new List<int>();
            listaValores.Add(_demonstration.NumberCriptTransmissions);
            listaValores.Add(_demonstration.NumberOpenedTransmissions);

            var series = chTransmissoes.Series[0];
            series.Points.Clear();

            for (int i = 0; i < listaLegendas.Count; i++)
            {
                var ponto = new DataPoint(i, listaValores[i]);
                ponto.LegendText = listaLegendas[i];

                if (_demonstration.NumberTransmissions > 0)
                    ponto.Label = listaLegendas[i] + " (" + (listaValores[i] * 100) / _demonstration.NumberTransmissions + "%)";

                series.Points.Add(ponto);
            }

            chTransmissoes.Update();
        }

        /* 
         * Show details of each packet (double click on packet grid)
         */
        private void dataGridPacotes_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPacotes.SelectedCells.Count == 0)
                return;

            var nroPacote = int.Parse(dataGridPacotes.Rows[dataGridPacotes.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            var pacote = _demonstration.AllPackets.First(x => x.ID == nroPacote);
            MessageBox.Show(pacote.Content, "Packet Details " + nroPacote);
        }

        /*
         * Load all packets of a specific transmission, when user selects a transmission
         */
        private void dataGridTransmissao_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTransmissao.SelectedCells.Count == 0)
            {
                return;
            }

            txDados.Clear();

            var nroTransmission = int.Parse(dataGridTransmissao.Rows[dataGridTransmissao.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            var transmission = _demonstration.AllTransmissions.First(x => x.ID == nroTransmission);

            foreach (var p in transmission.Packets)
            {
                if (txDados.Text.Equals(""))
                    txDados.Text = p.Content;
                else txDados.Text = txDados.Text + Environment.NewLine + p.Content;
            }

        }
    }
}
