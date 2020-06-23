namespace GUI
{
    partial class frmMovimentacaoVenda
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.btLocCli = new System.Windows.Forms.Button();
            this.txtCliCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDataini = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNParcela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtVenCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxVendaAVista = new System.Windows.Forms.CheckBox();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btCancelarFinal = new System.Windows.Forms.Button();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.cbValidaQtde = new System.Windows.Forms.CheckBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbValidaQtde);
            this.pnDados.Controls.Add(this.lbMsg);
            this.pnDados.Controls.Add(this.cbxVendaAVista);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.txtTotalVenda);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lCliente);
            this.pnDados.Controls.Add(this.btLocCli);
            this.pnDados.Controls.Add(this.txtCliCodigo);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbNParcela);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataVenda);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtVenCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lProduto);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Location = new System.Drawing.Point(6, 8);
            this.pnDados.Size = new System.Drawing.Size(770, 426);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(6, 438);
            this.pnBotoes.Size = new System.Drawing.Size(770, 107);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Text = "Cancelar Venda";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(11, 8);
            this.btAlterar.Visible = false;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(274, 8);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(143, 8);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(638, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 67;
            this.label12.Text = "Valor Unitário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(526, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 66;
            this.label11.Text = "Quantidade";
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.Color.White;
            this.btAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.Location = new System.Drawing.Point(737, 110);
            this.btAddProd.Margin = new System.Windows.Forms.Padding(4);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(22, 22);
            this.btAddProd.TabIndex = 65;
            this.btAddProd.Text = "+";
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 64;
            this.label13.Text = "Itens da Compra";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(637, 110);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 22);
            this.txtValor.TabIndex = 63;
            this.txtValor.Text = "0.00";
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(526, 110);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(84, 22);
            this.txtQtde.TabIndex = 62;
            this.txtQtde.Text = "0";
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(124, 109);
            this.btLocProd.Margin = new System.Windows.Forms.Padding(4);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(77, 24);
            this.btLocProd.TabIndex = 60;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCod.Location = new System.Drawing.Point(7, 110);
            this.txtProCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(115, 22);
            this.txtProCod.TabIndex = 59;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(629, 394);
            this.txtTotalVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(130, 22);
            this.txtTotalVenda.TabIndex = 57;
            this.txtTotalVenda.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(449, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Data da Venda";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(204, 67);
            this.lCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(350, 17);
            this.lCliente.TabIndex = 55;
            this.lCliente.Text = "Informe o código do Fornecedor ou clique em localizar";
            // 
            // btLocCli
            // 
            this.btLocCli.Location = new System.Drawing.Point(124, 64);
            this.btLocCli.Margin = new System.Windows.Forms.Padding(4);
            this.btLocCli.Name = "btLocCli";
            this.btLocCli.Size = new System.Drawing.Size(77, 24);
            this.btLocCli.TabIndex = 54;
            this.btLocCli.Text = "Localizar";
            this.btLocCli.UseVisualStyleBackColor = true;
            this.btLocCli.Click += new System.EventHandler(this.btLocCli_Click);
            // 
            // txtCliCodigo
            // 
            this.txtCliCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliCodigo.Location = new System.Drawing.Point(7, 64);
            this.txtCliCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliCodigo.Name = "txtCliCodigo";
            this.txtCliCodigo.Size = new System.Drawing.Size(112, 22);
            this.txtCliCodigo.TabIndex = 53;
            this.txtCliCodigo.Leave += new System.EventHandler(this.txtCliCodigo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Código do Cliente";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            this.dgvItens.Location = new System.Drawing.Point(6, 159);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(753, 208);
            this.dgvItens.TabIndex = 51;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 80;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 250;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitário";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 130;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(283, 391);
            this.dtDataini.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(170, 22);
            this.dtDataini.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Numero de Parcelas";
            // 
            // cbNParcela
            // 
            this.cbNParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNParcela.FormattingEnabled = true;
            this.cbNParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcela.Location = new System.Drawing.Point(4, 391);
            this.cbNParcela.Margin = new System.Windows.Forms.Padding(4);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(126, 24);
            this.cbNParcela.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(141, 391);
            this.cbTpagto.Margin = new System.Windows.Forms.Padding(4);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(131, 24);
            this.cbTpagto.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(680, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Valor Total";
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataVenda.Location = new System.Drawing.Point(475, 18);
            this.dtDataVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(284, 22);
            this.dtDataVenda.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Numero da Nota Fiscal";
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFiscal.Location = new System.Drawing.Point(156, 18);
            this.txtNFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(288, 22);
            this.txtNFiscal.TabIndex = 41;
            // 
            // txtVenCodigo
            // 
            this.txtVenCodigo.Enabled = false;
            this.txtVenCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenCodigo.Location = new System.Drawing.Point(6, 18);
            this.txtVenCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenCodigo.Name = "txtVenCodigo";
            this.txtVenCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtVenCodigo.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(604, 397);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 69;
            this.label15.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Código do Produto:";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(203, 112);
            this.lProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(326, 17);
            this.lProduto.TabIndex = 61;
            this.lProduto.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(607, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 20);
            this.label14.TabIndex = 68;
            this.label14.Text = "R$";
            // 
            // cbxVendaAVista
            // 
            this.cbxVendaAVista.AutoSize = true;
            this.cbxVendaAVista.Location = new System.Drawing.Point(475, 391);
            this.cbxVendaAVista.Name = "cbxVendaAVista";
            this.cbxVendaAVista.Size = new System.Drawing.Size(116, 21);
            this.cbxVendaAVista.TabIndex = 70;
            this.cbxVendaAVista.Text = "Venda a vista";
            this.cbxVendaAVista.UseVisualStyleBackColor = true;
            this.cbxVendaAVista.CheckedChanged += new System.EventHandler(this.cbxVendaAVista_CheckedChanged);
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.label20);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.label19);
            this.pnFinalizaCompra.Controls.Add(this.btCancelarFinal);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label18);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(782, 8);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(784, 539);
            this.pnFinalizaCompra.TabIndex = 7;
            this.pnFinalizaCompra.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(686, 406);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(727, 409);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 28;
            this.lbTotal.Text = "0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(568, 409);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "Total da venda:";
            // 
            // btCancelarFinal
            // 
            this.btCancelarFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarFinal.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelarFinal.Location = new System.Drawing.Point(668, 434);
            this.btCancelarFinal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCancelarFinal.Name = "btCancelarFinal";
            this.btCancelarFinal.Size = new System.Drawing.Size(100, 90);
            this.btCancelarFinal.TabIndex = 26;
            this.btCancelarFinal.Text = "Cancelar";
            this.btCancelarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelarFinal.UseVisualStyleBackColor = true;
            this.btCancelarFinal.Click += new System.EventHandler(this.btCancelarFinal_Click);
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFinal.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvarFinal.Location = new System.Drawing.Point(559, 434);
            this.btSalvarFinal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(100, 90);
            this.btSalvarFinal.TabIndex = 25;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarFinal.UseVisualStyleBackColor = true;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Parcelas da venda";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(13, 98);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.Size = new System.Drawing.Size(754, 297);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 45);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(749, 25);
            this.label17.TabIndex = 24;
            this.label17.Text = "___________________________________________________________________";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(82, 232);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(577, 76);
            this.lbMsg.TabIndex = 39;
            this.lbMsg.Text = "Venda Cancelada";
            this.lbMsg.Visible = false;
            // 
            // cbValidaQtde
            // 
            this.cbValidaQtde.AutoSize = true;
            this.cbValidaQtde.Location = new System.Drawing.Point(432, 134);
            this.cbValidaQtde.Name = "cbValidaQtde";
            this.cbValidaQtde.Size = new System.Drawing.Size(327, 21);
            this.cbValidaQtde.TabIndex = 71;
            this.cbValidaQtde.Text = "Verificar a quantidade de produtos em estoque";
            this.cbValidaQtde.UseVisualStyleBackColor = true;
            // 
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1616, 553);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmMovimentacaoVenda";
            this.Text = "Movimentação - Formulário de Venda";
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button btLocCli;
        private System.Windows.Forms.TextBox txtCliCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDataini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtVenCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbxVendaAVista;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Button btCancelarFinal;
        protected System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.CheckBox cbValidaQtde;
    }
}
