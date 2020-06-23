using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALVenda
    {
        private DALConexao conexao;
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda(ven_data,ven_nfiscal,ven_total,ven_nparcelas," +
            "ven_status,cli_cod,tpa_cod,ven_avista) values (@ven_data,@ven_nfiscal,@ven_total,@ven_nparcelas," +
            "@ven_status,@cli_cod,@tpa_cod,@ven_avista); select @@IDENTITY;";
            //quando o valor for uma data
            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@ven_data"].Value = modelo.VenData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);

            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set ven_data=@ven_data, ven_nfiscal=@ven_nfiscal," +
            "ven_total=@ven_total,ven_nparcelas=@ven_nparcelas,ven_status=@ven_status," +
            "cli_cod=@cli_cod,tpa_cod=@tpa_cod,ven_avista=@ven_avista where ven_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            //quando o valor for uma data
            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@ven_data"].Value = modelo.VenData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);
            cmd.ExecuteNonQuery();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from venda where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        //implementar cancelar venda
        public Boolean CancelarVenda(int codigo)
        {
            Boolean retorno = true;
            //atualizar a tabela de venda
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            //cmd.Transaction = conexao.ObjetoTransacao;
            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_status='cancelada' where ven_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                //substituir para o método do DALItensVenda
                // incrementar o estoque com os itens da venda cancelada
                //localiar os itens da venda
                DataTable tabela = new DataTable();
                
                SqlDataAdapter da = new SqlDataAdapter("select itv_cod, pro_cod, itv_qtde from itensvenda where ven_cod =" +
                    codigo.ToString(), conexao.StringConexao);
                da.Fill(tabela);
                //da.Dispose();
                //alterar a quantidade do estoque 
                ModeloProduto produto;
                //DALConexao cxp = new DALConexao(DadosDaConexao.StringDeConexao);
                //DALProduto dalProduto = new DALProduto(cxp);
                DALProduto dalProduto = new DALProduto(conexao);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]),true);
                    produto.ProQtde = produto.ProQtde + Convert.ToDouble(tabela.Rows[i]["itv_qtde"]);
                    dalProduto.Alterar(produto,true);
                }
                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch
            {
                conexao.CancelarTransacao();
                conexao.Desconectar();
                retorno = false;
            }
            return retorno;
        }
        //localizar pelo código do Cliente
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod,v.ven_data,v.ven_nfiscal," +
                "v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista,  v.ven_total"+
                //"v.ven_avista, v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_total" +
                " from venda v inner join cliente c on v.cli_cod = c.cli_cod" +
                " where c.cli_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //lista as compras pelo nome do cliente
        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod,v.ven_data,v.ven_nfiscal," +
                "v.ven_avista, v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_total" +
                " from venda v inner join cliente c on v.cli_cod = c.cli_cod" +
                " where c.cli_nome =  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //lista todas as vendas
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod,v.ven_data,v.ven_nfiscal," +
                "v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista,  v.ven_total" +
                " from venda v inner join cliente c on v.cli_cod = c.cli_cod", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
            
        }
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select distinct  v.ven_cod,v.ven_data,v.ven_nfiscal," +
               // "v.ven_nparcelas, c.cli_nome,v.ven_status, v.ven_avista, v.cli_cod, v.tpa_cod, v.ven_total " +
               "v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista,  v.ven_total" +
                " from venda v inner join cliente c on v.cli_cod = c.cli_cod " +
                "inner join parcelasvenda p on v.ven_cod = p.ven_cod where p.pve_datapagto is NULL", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(ven_cod) from parcelasvenda where ven_cod = @cod and pve_datapagto is NULL";
            cmd.Parameters.AddWithValue("@cod", Codigo);
            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return qtde;
        }

        //pela data inicial e final
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select v.ven_cod,v.ven_data,v.ven_nfiscal," +
                //"v.ven_nparcelas, v.ven_avista, c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_total" +
                "v.ven_nparcelas,c.cli_nome,v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista,  v.ven_total" +
                " from venda v inner join cliente c on v.cli_cod = c.cli_cod" +
                " where v.ven_data BETWEEN @dtinicial and @dtfinal";

            cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicial"].Value = dtinicial;

            cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfinal"].Value = dtfinal;
            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }


        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNFiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNParcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
