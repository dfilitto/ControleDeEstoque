using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRecebimentoVenda : Form
    {
        public int pveCod;
        public frmRecebimentoVenda()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            btReceber.Enabled = false;
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtCodigo.Text = modelo.VenCod.ToString();
                dtData.Value = modelo.VenData;
                BLLCliente bllf = new BLLCliente(cx);
                ModeloCliente modeloc = bllf.CarregaModeloCliente(modelo.CliCod);
                txtCliente.Text = modeloc.CliNome;
                txtValor.Text = modelo.VenTotal.ToString();

                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.VenCod);

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor da parcela";
                dgvParcelas.Columns[2].HeaderText = "Recebido em";
                dgvParcelas.Columns[3].HeaderText = "Vencimento";
                //dgvDados.Columns[0].Width = 50;
                dgvParcelas.Columns[4].Visible = false;
            }
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btReceber.Enabled = false;
            this.pveCod = 0;
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btReceber.Enabled = true;
                this.pveCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
            int venCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpRecebimento.Value;
            bllp.EfetuaRecebimentoParcela(venCod, this.pveCod, data);

            BLLParcelasCompra bll2p = new BLLParcelasCompra(cx);
            dgvParcelas.DataSource = bllp.Localizar(venCod);
            btReceber.Enabled = false;

            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor da parcela";
            dgvParcelas.Columns[2].HeaderText = "Recebido em";
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            //dgvDados.Columns[0].Width = 50;
            dgvParcelas.Columns[4].Visible = false;
        }
    }
}
