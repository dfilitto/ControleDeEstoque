
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;
using System.Security;
using System.IO;

namespace MaterialDosAssinantes
{
    public partial class FrmBackupBancoDeDados : Form
    {
        public FrmBackupBancoDeDados()
        {
            InitializeComponent();
        }
        private void BtBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
               
                d.FileName = string.Format("{0}_{1:yyyyMMdd_HHmmss}.bak", TxtDataBase.Text, DateTime.Now);
                if (d.FileName != "")
                {
                    String nomeBanco = TxtDataBase.Text;
                    String localBackup = Convert.ToString(TxtLocalBkp);
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" +
                                     DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtRestauracao_Click(object sender, EventArgs e)
        {            
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor  + ";Initial Catalog=master;User=" +
                                     DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    var server = new Microsoft.SqlServer.Management.Smo.Server(TxtLocalBkp.Text);
                    server.KillDatabase(TxtDataBase.Text);
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso!!!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void CbBackups_DropDown_1(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", TxtLocalBkp.Text, TxtDataBase.Text)))
            {
                connection.Open();
                using (var command = new System.Data.SqlClient.SqlCommand(
                    "SELECT physical_device_name FROM msdb.dbo.backupmediafamily " +
                    "INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id " +
                    "WHERE (msdb.dbo.backupset.database_name LIKE @DatabaseName)", connection))
                {
                    command.Parameters.AddWithValue("DatabaseName", TxtDataBase.Text);
                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        table.Columns.Add("FriendlyName");
                        foreach (DataRow row in table.Rows)
                        {
                            row["FriendlyName"] = System.IO.Path.GetFileName(row["physical_device_name"].ToString());
                        }
                        if (CbBackups.DataSource != null && CbBackups.DataSource is DataTable)
                        {
                            var oldTable = ((DataTable)CbBackups.DataSource);
                            CbBackups.DataSource = null;
                            oldTable.Dispose();
                        }
                        CbBackups.DataSource = table;
                        CbBackups.DisplayMember = "FriendlyName";
                        CbBackups.ValueMember = "physical_device_name";
                    }
                }
            }
        }
    }
}