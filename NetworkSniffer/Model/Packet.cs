using PacketDotNet;
using System;

namespace Sniffer.Model
{
    internal class MyPacket
    {
        public int ID;
        public string Protocol;
        public string AddressInitial;
        public string PortInitial;
        public string AddressFinal;
        public string PortFinal;
        public bool IsCript;
        public string Content;
        public Packet Packet;

        public String clNroPacote
        {
            get { return ID.ToString(); }
        }

        public String clProtocolo
        {
            get { return Protocol; }
        }

        public String clIPOrigem
        {
            get { return AddressInitial; }
        }

        public String clPortaOrigem
        {
            get { return PortInitial; }
        }

        public String clIPDestino
        {
            get { return AddressFinal; }
        }

        public String clPortaDestino
        {
            get { return PortFinal; }
        }

        public String clCriptografado
        {
            get
            {
                if (IsCript) return "Yes";
                else return "No";
            }
        }
    }
}
