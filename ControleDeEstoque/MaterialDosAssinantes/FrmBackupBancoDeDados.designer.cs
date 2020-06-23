namespace MaterialDosAssinantes
{
    partial class FrmBackupBancoDeDados
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
            this.BtRestauracao = new System.Windows.Forms.Button();
            this.BtBackup = new System.Windows.Forms.Button();
            this.TxtDataBase = new System.Windows.Forms.TextBox();
            this.TxtLocalBkp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbBackups = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtRestauracao
            // 
            this.BtRestauracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRestauracao.Location = new System.Drawing.Point(9, 164);
            this.BtRestauracao.Name = "BtRestauracao";
            this.BtRestauracao.Size = new System.Drawing.Size(535, 30);
            this.BtRestauracao.TabIndex = 12;
            this.BtRestauracao.Text = "Restauração";
            this.BtRestauracao.UseVisualStyleBackColor = true;
            this.BtRestauracao.Click += new System.EventHandler(this.BtRestauracao_Click);
            // 
            // BtBackup
            // 
            this.BtBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBackup.Location = new System.Drawing.Point(9, 125);
            this.BtBackup.Name = "BtBackup";
            this.BtBackup.Size = new System.Drawing.Size(535, 30);
            this.BtBackup.TabIndex = 11;
            this.BtBackup.Text = "Backup";
            this.BtBackup.UseVisualStyleBackColor = true;
            this.BtBackup.Click += new System.EventHandler(this.BtBackup_Click);
            // 
            // TxtDataBase
            // 
            this.TxtDataBase.Location = new System.Drawing.Point(282, 19);
            this.TxtDataBase.Name = "TxtDataBase";
            this.TxtDataBase.Size = new System.Drawing.Size(260, 20);
            this.TxtDataBase.TabIndex = 10;
            this.TxtDataBase.Text = "ControleDeEstoque";
            // 
            // TxtLocalBkp
            // 
            this.TxtLocalBkp.Location = new System.Drawing.Point(9, 19);
            this.TxtLocalBkp.Name = "TxtLocalBkp";
            this.TxtLocalBkp.Size = new System.Drawing.Size(260, 20);
            this.TxtLocalBkp.TabIndex = 9;
            this.TxtLocalBkp.Text = ".\\MSSQLEXPRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DataBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "                                                Backups Efetuados                " +
    "                              ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbBackups
            // 
            this.CbBackups.DropDownHeight = 200;
            this.CbBackups.DropDownWidth = 535;
            this.CbBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBackups.FormattingEnabled = true;
            this.CbBackups.IntegralHeight = false;
            this.CbBackups.ItemHeight = 20;
            this.CbBackups.Location = new System.Drawing.Point(9, 76);
            this.CbBackups.Name = "CbBackups";
            this.CbBackups.Size = new System.Drawing.Size(535, 28);
            this.CbBackups.TabIndex = 15;
            this.CbBackups.DropDown += new System.EventHandler(this.CbBackups_DropDown_1);
            // 
            // FrmBackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbBackups);
            this.Controls.Add(this.BtRestauracao);
            this.Controls.Add(this.BtBackup);
            this.Controls.Add(this.TxtDataBase);
            this.Controls.Add(this.TxtLocalBkp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRestauracao;
        private System.Windows.Forms.Button BtBackup;
        private System.Windows.Forms.TextBox TxtDataBase;
        private System.Windows.Forms.TextBox TxtLocalBkp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.ComboBox CbBackups;

    }
}