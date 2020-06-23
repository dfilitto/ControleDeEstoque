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
    public partial class frmConsultaCompra : Form
    {
        public int codigo = 0;
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }
        public void ExecutaConsulta(int op)
        {
            //op = 1 todas as compras
            //op = 2 por fornecedor
            //op = 3 data da compra
            //op = 4 parcelas em aberto
        }
        public void AtualizaCabecalhoDGCompra()
        {
            //dgvDados.Columns[1].Width = 700;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Data da compra";
            dgvDados.Columns[2].HeaderText = "Número da nota fiscal";
            dgvDados.Columns[3].HeaderText = "Número de parcelas";
            dgvDados.Columns[4].HeaderText = "Fornecedor";
            dgvDados.Columns[5].HeaderText = "Status da compra";
            dgvDados.Columns[6].HeaderText = "Código do fornecedor";
            dgvDados.Columns[7].HeaderText = "Código do tipo de pagamento";
            dgvDados.Columns[8].HeaderText = "Total";
            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[4].Width = 300;
            
        }
        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = "Nome do fornecedor: " + modelo.ForNome;
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGCompra();
            }
            else
            {
                txtForCod.Text = ""; lbForNome.Text = "Nome do fornecedor:";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paineis
            pFornecedor.Visible = false;
            pData.Visible = false;
            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;
            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar();
                this.AtualizaCabecalhoDGCompra();
            }
            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                pFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorParcelasEmAberto();
                this.AtualizaCabecalhoDGCompra();
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfim = dateTimePicker2.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            dgvDados.DataSource = bllcompra.Localizar(dtini,dtfim);
            this.AtualizaCabecalhoDGCompra();
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
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                //parcelas da compra
                BLLParcelasCompra bllParcelas = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                alteraCabecalhoItensParcelas();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
