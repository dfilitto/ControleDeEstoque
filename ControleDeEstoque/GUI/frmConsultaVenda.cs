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
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;
        public frmConsultaVenda()
        {
            InitializeComponent();
        }
        public void AtualizaCabecalhoDGVenda()
        {
            //dgvDados.Columns[1].Width = 700;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Data da venda";
            dgvDados.Columns[2].HeaderText = "Número da nota fiscal";
            dgvDados.Columns[3].HeaderText = "Número de parcelas";
            dgvDados.Columns[4].HeaderText = "Cliente";
            dgvDados.Columns[5].HeaderText = "Status da venda";
            dgvDados.Columns[6].HeaderText = "Código do cliente";
            dgvDados.Columns[7].HeaderText = "Código do tipo de pagamento";
            dgvDados.Columns[8].HeaderText = "Venda a vista ou a prazo";
            dgvDados.Columns[9].HeaderText = "Total";
            //dgvDados.Columns[3].Visible = false;
            //dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[4].Width = 300;

        }
        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paineis
            pCliente.Visible = false;
            pData.Visible = false;
            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;
            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabecalhoDGVenda();
            }
            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbCliente.Checked == true)
            {
                pCliente.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarPorParcelasEmAberto();
                this.AtualizaCabecalhoDGVenda();
            }
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender,e);
        }

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbCliNome.Text = "Nome do cliente: " + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGVenda();
            }
            else
            {
                txtCliCod.Text = ""; lbCliNome.Text = "Nome do Cliente:";
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfim = dateTimePicker2.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoDGVenda();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
        public void alteraCabecalhoItensParcelas()
        {
            try
            {
                dgvItens.Columns[0].Visible = false;
                dgvItens.Columns[1].HeaderText = "Código item";
                dgvItens.Columns[2].HeaderText = "Código Produto";
                dgvItens.Columns[3].HeaderText = "Nome Produto";
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[5].HeaderText = "Valor";
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[3].HeaderText = "Data de Vencimento";
                dgvParcelas.Columns[4].Visible = false;
            }
            catch { }
        }
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //itens da compra
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                //parcelas da compra
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                alteraCabecalhoItensParcelas();
            }
        }
    }
}
