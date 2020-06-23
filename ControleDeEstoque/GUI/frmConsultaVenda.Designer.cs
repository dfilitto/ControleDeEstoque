namespace GUI
{
    partial class frmConsultaVenda
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
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pCliente = new System.Windows.Forms.Panel();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.tbcDados.SuspendLayout();
            this.tpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pCliente.SuspendLayout();
            this.pData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpVenda);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(14, 125);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(755, 418);
            this.tbcDados.TabIndex = 20;
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.dgvDados);
            this.tpVenda.Location = new System.Drawing.Point(4, 25);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(747, 389);
            this.tpVenda.TabIndex = 0;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 5);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(735, 379);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 25);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(747, 389);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da venda selecionada";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 5);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(735, 379);
            this.dgvItens.TabIndex = 13;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 25);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(747, 389);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da venda selecionada";
            this.tpParcelas.UseVisualStyleBackColor = true;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(6, 5);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(735, 379);
            this.dgvParcelas.TabIndex = 13;
            // 
            // pCliente
            // 
            this.pCliente.Controls.Add(this.lbCliNome);
            this.pCliente.Controls.Add(this.btLocCliente);
            this.pCliente.Controls.Add(this.txtCliCod);
            this.pCliente.Controls.Add(this.label1);
            this.pCliente.Location = new System.Drawing.Point(17, 60);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(747, 54);
            this.pCliente.TabIndex = 18;
            this.pCliente.Visible = false;
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Location = new System.Drawing.Point(164, 5);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(114, 17);
            this.lbCliNome.TabIndex = 3;
            this.lbCliNome.Text = "Nome do cliente:";
            // 
            // btLocCliente
            // 
            this.btLocCliente.Location = new System.Drawing.Point(164, 25);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(178, 23);
            this.btLocCliente.TabIndex = 2;
            this.btLocCliente.Text = "Localizar Cliente";
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(16, 25);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(142, 22);
            this.txtCliCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do cliente";
            // 
            // pData
            // 
            this.pData.Controls.Add(this.label2);
            this.pData.Controls.Add(this.dateTimePicker2);
            this.pData.Controls.Add(this.dateTimePicker1);
            this.pData.Controls.Add(this.btLocData);
            this.pData.Controls.Add(this.label3);
            this.pData.Location = new System.Drawing.Point(12, 60);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(747, 59);
            this.pData.TabIndex = 19;
            this.pData.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btLocData
            // 
            this.btLocData.Location = new System.Drawing.Point(542, 31);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(178, 23);
            this.btLocData.TabIndex = 2;
            this.btLocData.Text = "Localizar";
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicial";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(747, 49);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo:";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(16, 19);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(138, 21);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(568, 19);
            this.rbParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(152, 21);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(380, 19);
            this.rbData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(122, 21);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da venda";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(220, 19);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(72, 21);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pCliente);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de vendas";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            this.tbcDados.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
    }
}