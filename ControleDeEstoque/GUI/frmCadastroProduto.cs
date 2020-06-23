using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Modelo;
using GUI;
using DAL;
using System.IO;

namespace GUI
{
    public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";
        public frmCadastroProduto()
        {  
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQtde.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            //cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch 
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
            
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",")==txtValorPago.Text.Length-1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtde.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (txtQtde.Text.Contains(",") == false)
            {
                txtQtde.Text += ",00";
            }
            else
            {
                if (txtQtde.Text.IndexOf(",") == txtQtde.Text.Length - 1)
                {
                    txtQtde.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtde.Text);
            }
            catch
            {
                txtQtde.Text = "0,00";
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                modelo.UmedCod = Convert.ToInt32(cbUnd.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);
                
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma Produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());

                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);  
                    //alterar um produto
                    if ( this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cbSubCategoria.Text = "";
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
            
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
             frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                //colocar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtNome.Text = modelo.ProNome;
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUnd.SelectedValue = modelo.UmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch {}

                txtQtde_Leave(sender,e);
                txtValorPago_Leave(sender, e);
                txtValorVenda_Leave(sender, e); 
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
         
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btaddCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }

        }

        private void btaddSubCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();

            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btAddUnidadeMedida_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
            
        }
    }
}
