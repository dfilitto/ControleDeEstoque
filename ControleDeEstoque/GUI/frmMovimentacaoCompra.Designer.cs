namespace GUI
{
    partial class frmMovimentacaoCompra
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
            this.pnDados = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lFornecedor = new System.Windows.Forms.Label();
            this.btLocFor = new System.Windows.Forms.Button();
            this.txtForCodigo = new System.Windows.Forms.TextBox();
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
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtComCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
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
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lFornecedor);
            this.pnDados.Controls.Add(this.btLocFor);
            this.pnDados.Controls.Add(this.txtForCodigo);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbNParcela);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtComCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lProduto);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Location = new System.Drawing.Point(6, 8);
            this.pnDados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(770, 426);
            this.pnDados.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(641, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "Valor Unitário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(529, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Quantidade";
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.Color.White;
            this.btAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.Location = new System.Drawing.Point(740, 121);
            this.btAddProd.Margin = new System.Windows.Forms.Padding(4);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(22, 22);
            this.btAddProd.TabIndex = 34;
            this.btAddProd.Text = "+";
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Itens da Compra";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(640, 121);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 22);
            this.txtValor.TabIndex = 31;
            this.txtValor.Text = "0.00";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(529, 121);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(84, 22);
            this.txtQtde.TabIndex = 30;
            this.txtQtde.Text = "0";
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(127, 120);
            this.btLocProd.Margin = new System.Windows.Forms.Padding(4);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(77, 24);
            this.btLocProd.TabIndex = 27;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCod.Location = new System.Drawing.Point(10, 121);
            this.txtProCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(115, 22);
            this.txtProCod.TabIndex = 26;
            this.txtProCod.TextChanged += new System.EventHandler(this.txtProCod_TextChanged);
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(632, 400);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(130, 22);
            this.txtTotalCompra.TabIndex = 24;
            this.txtTotalCompra.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Data da Compra";
            // 
            // lFornecedor
            // 
            this.lFornecedor.AutoSize = true;
            this.lFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFornecedor.Location = new System.Drawing.Point(207, 73);
            this.lFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFornecedor.Name = "lFornecedor";
            this.lFornecedor.Size = new System.Drawing.Size(350, 17);
            this.lFornecedor.TabIndex = 21;
            this.lFornecedor.Text = "Informe o código do Fornecedor ou clique em localizar";
            // 
            // btLocFor
            // 
            this.btLocFor.Location = new System.Drawing.Point(127, 70);
            this.btLocFor.Margin = new System.Windows.Forms.Padding(4);
            this.btLocFor.Name = "btLocFor";
            this.btLocFor.Size = new System.Drawing.Size(77, 24);
            this.btLocFor.TabIndex = 20;
            this.btLocFor.Text = "Localizar";
            this.btLocFor.UseVisualStyleBackColor = true;
            this.btLocFor.Click += new System.EventHandler(this.btLocFor_Click);
            // 
            // txtForCodigo
            // 
            this.txtForCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForCodigo.Location = new System.Drawing.Point(10, 70);
            this.txtForCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtForCodigo.Name = "txtForCodigo";
            this.txtForCodigo.Size = new System.Drawing.Size(112, 22);
            this.txtForCodigo.TabIndex = 19;
            this.txtForCodigo.Leave += new System.EventHandler(this.txtForCodigo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código do Fornecedor";
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
            this.dgvItens.Location = new System.Drawing.Point(9, 165);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(753, 208);
            this.dgvItens.TabIndex = 17;
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
            this.label6.Location = new System.Drawing.Point(283, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(286, 397);
            this.dtDataini.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(170, 22);
            this.dtDataini.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 14;
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
            this.cbNParcela.Location = new System.Drawing.Point(7, 397);
            this.cbNParcela.Margin = new System.Windows.Forms.Padding(4);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(126, 24);
            this.cbNParcela.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(144, 397);
            this.cbTpagto.Margin = new System.Windows.Forms.Padding(4);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(131, 24);
            this.cbTpagto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(683, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor Total";
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataCompra.Location = new System.Drawing.Point(478, 24);
            this.dtDataCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(284, 22);
            this.dtDataCompra.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero da Nota Fiscal";
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFiscal.Location = new System.Drawing.Point(159, 24);
            this.txtNFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(288, 22);
            this.txtNFiscal.TabIndex = 6;
            this.txtNFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFiscal_KeyPress);
            // 
            // txtComCodigo
            // 
            this.txtComCodigo.Enabled = false;
            this.txtComCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComCodigo.Location = new System.Drawing.Point(9, 24);
            this.txtComCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtComCodigo.Name = "txtComCodigo";
            this.txtComCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtComCodigo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(607, 403);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(749, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "___________________________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Código do Produto:";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(206, 123);
            this.lProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(326, 17);
            this.lProduto.TabIndex = 28;
            this.lProduto.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(610, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "R$";
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btnCancelar);
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnAlterar);
            this.pnBotoes.Controls.Add(this.btnLocalizar);
            this.pnBotoes.Controls.Add(this.btnExcluir);
            this.pnBotoes.Controls.Add(this.btnInserir);
            this.pnBotoes.Location = new System.Drawing.Point(6, 442);
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(770, 105);
            this.pnBotoes.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(664, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 90);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btnSalvar.Location = new System.Drawing.Point(534, 11);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 90);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::GUI.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(274, 11);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 90);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
            this.btnLocalizar.Location = new System.Drawing.Point(144, 11);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(100, 90);
            this.btnLocalizar.TabIndex = 7;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GUI.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(404, 11);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 90);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::GUI.Properties.Resources.Novo;
            this.btnInserir.Location = new System.Drawing.Point(14, 11);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 90);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
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
            this.pnFinalizaCompra.Location = new System.Drawing.Point(6, 5);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(784, 539);
            this.pnFinalizaCompra.TabIndex = 6;
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
            this.label19.Size = new System.Drawing.Size(115, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "Total da compra:";
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
            this.btCancelarFinal.Click += new System.EventHandler(this.button1_Click);
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
            this.label18.Size = new System.Drawing.Size(134, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Parcelas da compra";
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
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 553);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMovimentacaoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação - Formulário de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lFornecedor;
        private System.Windows.Forms.Button btLocFor;
        private System.Windows.Forms.TextBox txtForCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDataini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtComCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        protected System.Windows.Forms.Button btCancelarFinal;
        protected System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
    }
}