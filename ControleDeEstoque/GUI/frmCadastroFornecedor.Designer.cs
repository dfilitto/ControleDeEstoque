namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lbRGIE = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.txtFone);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.txtRsocial);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.txtCNPJ);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.lbRGIE);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.txtIE);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label4);
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
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(255, 150);
            this.lbValorIncorreto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(101, 17);
            this.lbValorIncorreto.TabIndex = 58;
            this.lbValorIncorreto.Text = "Valor Incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(399, 385);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(332, 22);
            this.txtCelular.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Celular";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(23, 385);
            this.txtFone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(332, 22);
            this.txtFone.TabIndex = 55;
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFone_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 342);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(707, 22);
            this.txtEmail.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(23, 299);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(707, 22);
            this.txtBairro.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(631, 257);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(23, 257);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(599, 22);
            this.txtRua.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(400, 214);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(329, 22);
            this.txtCidade.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(143, 214);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(213, 22);
            this.txtEstado.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Estado";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(23, 214);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 22);
            this.txtCep.TabIndex = 41;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "CEP";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(400, 169);
            this.txtIE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(329, 22);
            this.txtIE.TabIndex = 39;
            // 
            // lbRGIE
            // 
            this.lbRGIE.AutoSize = true;
            this.lbRGIE.Location = new System.Drawing.Point(400, 150);
            this.lbRGIE.Name = "lbRGIE";
            this.lbRGIE.Size = new System.Drawing.Size(20, 17);
            this.lbRGIE.TabIndex = 38;
            this.lbRGIE.Text = "IE";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(23, 169);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(332, 22);
            this.txtCNPJ.TabIndex = 37;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(20, 150);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(43, 17);
            this.lbCPFCNPJ.TabIndex = 36;
            this.lbCPFCNPJ.Text = "CNPJ";
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(23, 124);
            this.txtRsocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(708, 22);
            this.txtRsocial.TabIndex = 35;
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(20, 105);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(91, 17);
            this.lbRSocial.TabIndex = 34;
            this.lbRSocial.Text = "Razão Social";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(708, 22);
            this.txtNome.TabIndex = 33;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(19, 61);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 32;
            this.lbNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRGIE;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
    }
}
