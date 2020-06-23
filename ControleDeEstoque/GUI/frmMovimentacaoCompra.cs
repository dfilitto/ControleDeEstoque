using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmMovimentacaoCompra : Form
    {
        public double totalCompra = 0;//Variavel Global

        public String operacao;

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            //op = operacoes que serao feitas com os botoes
            //1 = Preparar os botoes para inserir e localizar
            //2 = Preparar os para inserir /alterar um registro
            //3 = Preparr a tela para excluir ou alterar 
            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            txtComCodigo.Clear(); txtNFiscal.Clear(); txtForCodigo.Clear(); txtProCod.Clear();
            lProduto.Text = "Informe o código do produto ou clique em localizar";
            txtQtde.Clear(); txtValor.Clear(); txtTotalCompra.Clear();
            dgvItens.Rows.Clear(); //limpar as linhas da dataGrid
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            alteraBotoes(2);

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtComCodigo.Text = modelo.ComCod.ToString();
                txtNFiscal.Text = modelo.ComNFiscal.ToString();
                dtDataCompra.Value = modelo.ComData;
                txtForCodigo.Text = modelo.ForCod.ToString();
                txtForCodigo_Leave(sender, e); //para escrever o nome do fornecedor na tela
                cbTpagto.SelectedValue = modelo.TpaCod;
                cbNParcela.Text = modelo.ComNParcelas.ToString();
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; //armazenar o valor total da compra
                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itc_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);

                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtComCodigo.Text);
            int qtde = Convert.ToInt32(cbNParcela.Text);
            //conexao e bll da compra
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);
            qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
            if (qtde == 0) //paguei alguma parcela
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossivel Alterar o registro.\n O registro possui parcelas pagas.");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro ?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtComCodigo.Text);
                    int qtde = Convert.ToInt32(cbNParcela.Text);
                    //conexao e bll da compra
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);
                    qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
                    if (qtde == 0) //paguei alguma parcela
                    {
                        cx.Conectar();
                        cx.IniciarTransacao();
                        try
                        {
                            //excluir as parcelas da compra
                            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                            bllp.ExcluirTodasAsParcelas(codigo);
                            //itens da compra
                            BLLItensCompra blli = new BLLItensCompra(cx);
                            blli.ExcluirTodosOsItens(codigo);
                            //compra
                            bllc.Excluir(codigo);
                            cx.TerminarTransacao();
                            cx.Desconectar();

                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossivel Excluir o registro.\n O registro possui parcelas pagas.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossivel Excluir o registro.\n O registro esta sendo utilizado em outro local.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNFiscal.Text == "")
            {
                MessageBox.Show("Informe número da nota fiscal de compra");
                return;
            }
            if (txtForCodigo.Text == "")
            {
                MessageBox.Show("Informe um fornecedor para a compra");
                return;
            }
            if (this.totalCompra <= 0) //validação dos itens
            {
                MessageBox.Show("Informe os produtos dessa compra");
                return;
            }

            dgvParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbNParcela.Text);
            //Double totallocal = Convert.ToDouble(txtTotalCompra.Text);
            Double totallocal = this.totalCompra;
            double valor = totallocal / parcelas; //valor = this.total/parcelas
            DateTime dt = new DateTime();
            dt = dtDataini.Value;
            lbTotal.Text = this.totalCompra.ToString();
            for (int i = 1; i <= parcelas; i++)
            {
                String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                this.dgvParcelas.Rows.Add(k);
                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            pnFinalizaCompra.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alteraBotoes(1);
            LimpaTela();
            this.totalCompra = 0;
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {

            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCodigo.Text = f.codigo.ToString();
                txtForCodigo_Leave(sender, e);
                //chamada do método do txtForCod
            }
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";
            cbNParcela.SelectedIndex = 0;
        }

        private void txtForCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCodigo.Text));

                if (modelo.ForCod <= 0)
                {
                    txtForCodigo.Clear();
                    lFornecedor.Text = "Informe o código do produto ou clique em localizar";
                }
                else lFornecedor.Text = modelo.ForNome;
            }
            catch
            {
                txtForCodigo.Clear();
                lFornecedor.Text = "Informe o código do produto ou clique em localizar";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();

                txtProCod_Leave(sender, e);
                //chamada do método do txtForCod
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lProduto.Text = modelo.ProNome;
                txtQtde.Text = " 1";
                txtValor.Text = Convert.ToString((Decimal) modelo.ProValorVenda);
         
            }
            catch
            {
                txtProCod.Clear();
                lProduto.Text = "Informe o código do produto ou clique em localizar";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);//metodo para calcular o total do produto
                    this.totalCompra = this.totalCompra + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtProCod.Text, lProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };//criado vetor de string
                    this.dgvItens.Rows.Add(i);//adicionando o string dentro da datagrid

                    txtProCod.Clear();//limpar o campo
                    lProduto.Text = "Informe o código do produto ou clique em localizar";
                    txtQtde.Clear();//limpar o campo
                    txtValor.Clear();//limpar o campo

                    txtTotalCompra.Text = this.totalCompra.ToString();//atualizar o total da compra

                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void txtProCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }
        //proCod -> produto que você quer verificar
        private Double VerificaDgvItens(int proCod)
        {
            Double proQtde = 0; //quantidade ja comprada
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                //compara se o código do produto que esta na coluna 0 é igual a proCod
                if (Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value) == proCod)
                {
                    //o que esta na coluna 3 é a quantidade dos produtos
                    proQtde = proQtde + Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                }
            }
            return proQtde;
        }
        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcela.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCodigo.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);

                //obj para gravar os dados no banco
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra ok
                    bll.Incluir(modeloCompra);
                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //alterar a quantidade de produtos comprados na tabela de produtos
                        //Trigger
                    }
                    // inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    //cadastrar as parcelas da compra
                    MessageBox.Show("Compra efetuada: Código " + modeloCompra.ComCod.ToString());

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCodigo.Text);
                    bll.Alterar(modeloCompra);

                    bitens.ExcluirTodosOsItens(modeloCompra.ComCod);
                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //alterar a quantidade de produtos comprados na tabela de produtos
                        //Trigger
                    }
                    bparcelas.ExcluirTodasAsParcelas(modeloCompra.ComCod);
                    // inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                pnFinalizaCompra.Visible = false;
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void txtNFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
           // Moeda(ref txtValor);
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch
            {

            }
        }
    }
    }

