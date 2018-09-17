namespace NetworkSniffer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.cbNetworkInterface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPacotes = new System.Windows.Forms.DataGridView();
            this.clNroPacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIPOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPortaOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIPDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPortaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCriptografado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTransmissoes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAbertas = new System.Windows.Forms.Label();
            this.lbCripto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPacotes = new System.Windows.Forms.TabPage();
            this.tabTransmissoes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txDados = new System.Windows.Forms.TextBox();
            this.dataGridTransmissao = new System.Windows.Forms.DataGridView();
            this.imgBusy = new System.Windows.Forms.PictureBox();
            this.clNroTransmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPorta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPorta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQtdPacotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTransmissoes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPacotes.SuspendLayout();
            this.tabTransmissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransmissao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusy)).BeginInit();
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(17, 32);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(189, 23);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "Start Capture";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btStartCapture_Click);
            // 
            // btEncerrar
            // 
            this.btEncerrar.Enabled = false;
            this.btEncerrar.Location = new System.Drawing.Point(213, 32);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(189, 23);
            this.btEncerrar.TabIndex = 2;
            this.btEncerrar.Text = "Stop Capture";
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // cbNetworkInterface
            // 
            this.cbNetworkInterface.AccessibleName = "";
            this.cbNetworkInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNetworkInterface.FormattingEnabled = true;
            this.cbNetworkInterface.Location = new System.Drawing.Point(129, 7);
            this.cbNetworkInterface.Name = "cbNetworkInterface";
            this.cbNetworkInterface.Size = new System.Drawing.Size(273, 21);
            this.cbNetworkInterface.TabIndex = 3;
            this.cbNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.cbNetworkInterface_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Network Interface";
            // 
            // dataGridPacotes
            // 
            this.dataGridPacotes.AllowUserToAddRows = false;
            this.dataGridPacotes.AllowUserToDeleteRows = false;
            this.dataGridPacotes.AllowUserToOrderColumns = true;
            this.dataGridPacotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPacotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridPacotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNroPacote,
            this.clProtocolo,
            this.clIPOrigem,
            this.clPortaOrigem,
            this.clIPDestino,
            this.clPortaDestino,
            this.clCriptografado});
            this.dataGridPacotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPacotes.Location = new System.Drawing.Point(3, 3);
            this.dataGridPacotes.MultiSelect = false;
            this.dataGridPacotes.Name = "dataGridPacotes";
            this.dataGridPacotes.ReadOnly = true;
            this.dataGridPacotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPacotes.Size = new System.Drawing.Size(833, 552);
            this.dataGridPacotes.TabIndex = 5;
            this.dataGridPacotes.DoubleClick += new System.EventHandler(this.dataGridPacotes_DoubleClick);
            // 
            // clNroPacote
            // 
            this.clNroPacote.DataPropertyName = "clNroPacote";
            this.clNroPacote.HeaderText = "ID";
            this.clNroPacote.Name = "clNroPacote";
            this.clNroPacote.ReadOnly = true;
            // 
            // clProtocolo
            // 
            this.clProtocolo.DataPropertyName = "clProtocolo";
            this.clProtocolo.HeaderText = "Protocol";
            this.clProtocolo.Name = "clProtocolo";
            this.clProtocolo.ReadOnly = true;
            // 
            // clIPOrigem
            // 
            this.clIPOrigem.DataPropertyName = "clIPOrigem";
            this.clIPOrigem.HeaderText = "IP 1";
            this.clIPOrigem.Name = "clIPOrigem";
            this.clIPOrigem.ReadOnly = true;
            // 
            // clPortaOrigem
            // 
            this.clPortaOrigem.DataPropertyName = "clPortaOrigem";
            this.clPortaOrigem.HeaderText = "Port 1";
            this.clPortaOrigem.Name = "clPortaOrigem";
            this.clPortaOrigem.ReadOnly = true;
            // 
            // clIPDestino
            // 
            this.clIPDestino.DataPropertyName = "clIPDestino";
            this.clIPDestino.HeaderText = "IP 2";
            this.clIPDestino.Name = "clIPDestino";
            this.clIPDestino.ReadOnly = true;
            // 
            // clPortaDestino
            // 
            this.clPortaDestino.DataPropertyName = "clPortaDestino";
            this.clPortaDestino.HeaderText = "Port 2";
            this.clPortaDestino.Name = "clPortaDestino";
            this.clPortaDestino.ReadOnly = true;
            // 
            // clCriptografado
            // 
            this.clCriptografado.DataPropertyName = "clCriptografado";
            this.clCriptografado.HeaderText = "Is Cript?";
            this.clCriptografado.Name = "clCriptografado";
            this.clCriptografado.ReadOnly = true;
            // 
            // chTransmissoes
            // 
            this.chTransmissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chTransmissoes.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legendas";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend1.Title = "Legendas";
            this.chTransmissoes.Legends.Add(legend1);
            this.chTransmissoes.Location = new System.Drawing.Point(870, 90);
            this.chTransmissoes.Name = "chTransmissoes";
            this.chTransmissoes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legendas";
            series1.Name = "srTransmissoes";
            this.chTransmissoes.Series.Add(series1);
            this.chTransmissoes.Size = new System.Drawing.Size(403, 240);
            this.chTransmissoes.TabIndex = 6;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Captured Transmissions";
            this.chTransmissoes.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAbertas);
            this.groupBox1.Controls.Add(this.lbCripto);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(882, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 41);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmissions";
            // 
            // lbAbertas
            // 
            this.lbAbertas.AutoSize = true;
            this.lbAbertas.Location = new System.Drawing.Point(31, 19);
            this.lbAbertas.Name = "lbAbertas";
            this.lbAbertas.Size = new System.Drawing.Size(55, 13);
            this.lbAbertas.TabIndex = 10;
            this.lbAbertas.Text = "Opened:";
            // 
            // lbCripto
            // 
            this.lbCripto.AutoSize = true;
            this.lbCripto.Location = new System.Drawing.Point(139, 19);
            this.lbCripto.Name = "lbCripto";
            this.lbCripto.Size = new System.Drawing.Size(37, 13);
            this.lbCripto.TabIndex = 9;
            this.lbCripto.Text = "Cript:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(274, 19);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 13);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPacotes);
            this.tabControl1.Controls.Add(this.tabTransmissoes);
            this.tabControl1.Location = new System.Drawing.Point(17, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 584);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPacotes
            // 
            this.tabPacotes.Controls.Add(this.dataGridPacotes);
            this.tabPacotes.Location = new System.Drawing.Point(4, 22);
            this.tabPacotes.Name = "tabPacotes";
            this.tabPacotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacotes.Size = new System.Drawing.Size(839, 558);
            this.tabPacotes.TabIndex = 0;
            this.tabPacotes.Text = "Captured Packets";
            this.tabPacotes.UseVisualStyleBackColor = true;
            // 
            // tabTransmissoes
            // 
            this.tabTransmissoes.Controls.Add(this.label2);
            this.tabTransmissoes.Controls.Add(this.txDados);
            this.tabTransmissoes.Controls.Add(this.dataGridTransmissao);
            this.tabTransmissoes.Location = new System.Drawing.Point(4, 22);
            this.tabTransmissoes.Name = "tabTransmissoes";
            this.tabTransmissoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransmissoes.Size = new System.Drawing.Size(839, 558);
            this.tabTransmissoes.TabIndex = 1;
            this.tabTransmissoes.Text = "Captured Transmissions";
            this.tabTransmissoes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados da Transmissão:";
            // 
            // txDados
            // 
            this.txDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txDados.Location = new System.Drawing.Point(3, 371);
            this.txDados.Multiline = true;
            this.txDados.Name = "txDados";
            this.txDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txDados.Size = new System.Drawing.Size(833, 184);
            this.txDados.TabIndex = 1;
            // 
            // dataGridTransmissao
            // 
            this.dataGridTransmissao.AllowUserToAddRows = false;
            this.dataGridTransmissao.AllowUserToDeleteRows = false;
            this.dataGridTransmissao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransmissao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridTransmissao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTransmissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransmissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNroTransmissao,
            this.clIP1,
            this.clPorta1,
            this.clIP2,
            this.clPorta2,
            this.clQtdPacotes});
            this.dataGridTransmissao.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridTransmissao.Location = new System.Drawing.Point(3, 3);
            this.dataGridTransmissao.Name = "dataGridTransmissao";
            this.dataGridTransmissao.ReadOnly = true;
            this.dataGridTransmissao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridTransmissao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTransmissao.Size = new System.Drawing.Size(833, 349);
            this.dataGridTransmissao.TabIndex = 0;
            this.dataGridTransmissao.SelectionChanged += new System.EventHandler(this.dataGridTransmissao_SelectionChanged);
            // 
            // imgBusy
            // 
            this.imgBusy.Image = global::NetworkSniffer.Properties.Resources.hex_loader2;
            this.imgBusy.Location = new System.Drawing.Point(308, -67);
            this.imgBusy.Margin = new System.Windows.Forms.Padding(0);
            this.imgBusy.Name = "imgBusy";
            this.imgBusy.Size = new System.Drawing.Size(323, 203);
            this.imgBusy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusy.TabIndex = 1;
            this.imgBusy.TabStop = false;
            this.imgBusy.Visible = false;
            // 
            // clNroTransmissao
            // 
            this.clNroTransmissao.DataPropertyName = "clNroTransmissao";
            this.clNroTransmissao.HeaderText = "ID";
            this.clNroTransmissao.Name = "clNroTransmissao";
            this.clNroTransmissao.ReadOnly = true;
            // 
            // clIP1
            // 
            this.clIP1.DataPropertyName = "clIP1";
            this.clIP1.HeaderText = "IP 1";
            this.clIP1.Name = "clIP1";
            this.clIP1.ReadOnly = true;
            // 
            // clPorta1
            // 
            this.clPorta1.DataPropertyName = "clPorta1";
            this.clPorta1.HeaderText = "Port 1";
            this.clPorta1.Name = "clPorta1";
            this.clPorta1.ReadOnly = true;
            // 
            // clIP2
            // 
            this.clIP2.DataPropertyName = "clIP2";
            this.clIP2.HeaderText = "IP 2";
            this.clIP2.Name = "clIP2";
            this.clIP2.ReadOnly = true;
            // 
            // clPorta2
            // 
            this.clPorta2.DataPropertyName = "clPorta2";
            this.clPorta2.HeaderText = "Port 2";
            this.clPorta2.Name = "clPorta2";
            this.clPorta2.ReadOnly = true;
            // 
            // clQtdPacotes
            // 
            this.clQtdPacotes.DataPropertyName = "clQtdPacotes";
            this.clQtdPacotes.HeaderText = "# Packets";
            this.clQtdPacotes.Name = "clQtdPacotes";
            this.clQtdPacotes.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1285, 658);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chTransmissoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNetworkInterface);
            this.Controls.Add(this.btEncerrar);
            this.Controls.Add(this.imgBusy);
            this.Controls.Add(this.btIniciar);
            this.Name = "MainForm";
            this.Text = "Network Sniffer by Fernando Abel e Tiago Molin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTransmissoes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPacotes.ResumeLayout(false);
            this.tabTransmissoes.ResumeLayout(false);
            this.tabTransmissoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransmissao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.PictureBox imgBusy;
        private System.Windows.Forms.Button btEncerrar;
        private System.Windows.Forms.ComboBox cbNetworkInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPacotes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTransmissoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbAbertas;
        private System.Windows.Forms.Label lbCripto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPacotes;
        private System.Windows.Forms.TabPage tabTransmissoes;
        private System.Windows.Forms.DataGridView dataGridTransmissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNroPacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIPOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPortaOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIPDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPortaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCriptografado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNroTransmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPorta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPorta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQtdPacotes;
    }
}

