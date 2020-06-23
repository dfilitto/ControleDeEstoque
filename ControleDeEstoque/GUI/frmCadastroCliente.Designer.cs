namespace GUI
{
    partial class frmCadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lbRGIE = new System.Windows.Forms.Label();
            this.txtRGIE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtFone);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtRGIE);
            this.pnDados.Controls.Add(this.lbRGIE);
            this.pnDados.Controls.Add(this.txtCPFCNPJ);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.txtRsocial);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.groupBox1);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Margin = new System.Windows.Forms.Padding(4);
            this.pnDados.Size = new System.Drawing.Size(757, 420);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(27, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(23, 69);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 89);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(708, 22);
            this.txtNome.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJuridica);
            this.groupBox1.Controls.Add(this.rbFisica);
            this.groupBox1.Location = new System.Drawing.Point(164, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do cliente";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(175, 15);
            this.rbJuridica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(78, 21);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(17, 15);
            this.rbFisica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(65, 21);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(24, 113);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(91, 17);
            this.lbRSocial.TabIndex = 5;
            this.lbRSocial.Text = "Razão Social";
            this.lbRSocial.Visible = false;
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(27, 132);
            this.txtRsocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(708, 22);
            this.txtRsocial.TabIndex = 6;
            this.txtRsocial.Visible = false;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(24, 158);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(34, 17);
            this.lbCPFCNPJ.TabIndex = 7;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(27, 177);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(332, 22);
            this.txtCPFCNPJ.TabIndex = 8;
            this.txtCPFCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFCNPJ_KeyPress);
            this.txtCPFCNPJ.Leave += new System.EventHandler(this.txtCPFCNPJ_Leave);
            // 
            // lbRGIE
            // 
            this.lbRGIE.AutoSize = true;
            this.lbRGIE.Location = new System.Drawing.Point(404, 158);
            this.lbRGIE.Name = "lbRGIE";
            this.lbRGIE.Size = new System.Drawing.Size(29, 17);
            this.lbRGIE.TabIndex = 9;
            this.lbRGIE.Text = "RG";
            // 
            // txtRGIE
            // 
            this.txtRGIE.Location = new System.Drawing.Point(404, 177);
            this.txtRGIE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRGIE.Name = "txtRGIE";
            this.txtRGIE.Size = new System.Drawing.Size(329, 22);
            this.txtRGIE.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(27, 222);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 22);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(147, 222);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(213, 22);
            this.txtEstado.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(404, 222);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(329, 22);
            this.txtCidade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(27, 263);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(599, 22);
            this.txtRua.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(635, 263);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 20;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(27, 305);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(707, 22);
            this.txtBairro.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bairro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(27, 348);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(707, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(27, 391);
            this.txtFone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(332, 22);
            this.txtFone.TabIndex = 26;
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFone_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Telefone";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(403, 391);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(332, 22);
            this.txtCelular.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Celular";
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(259, 158);
            this.lbValorIncorreto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(101, 17);
            this.lbValorIncorreto.TabIndex = 29;
            this.lbValorIncorreto.Text = "Valor Incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRGIE;
        private System.Windows.Forms.Label lbRGIE;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValorIncorreto;
    }
}
