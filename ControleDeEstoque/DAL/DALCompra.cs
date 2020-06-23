using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCompra
    {
        private DALConexao conexao;
        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into compra(com_data,com_nfiscal,com_total,com_nparcelas,"+
            "com_status,for_cod,tpa_cod) values (@com_data,@com_nfiscal,@com_total,@com_nparcelas,"+
            "@com_status,@for_cod,@tpa_cod); select @@IDENTITY;";
            //quando o valor for uma data
            cmd.Parameters.Add("@com_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@com_data"].Value = modelo.ComData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@com_nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@com_total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@com_nparcelas", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@com_status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@for_cod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);

            //conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            //conexao.Desconectar();
        }
        public void Alterar(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update compra set com_data=@com_data, com_nfiscal=@com_nfiscal,"+
            "com_total=@com_total,com_nparcelas=@com_nparcelas,com_status=@com_status," +
            "for_cod=@for_cod,tpa_cod=@tpa_cod where com_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);
            //quando o valor for uma data
            cmd.Parameters.Add("@com_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@com_data"].Value = modelo.ComData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@com_nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@com_total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@com_nparcelas", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@com_status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@for_cod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.ExecuteNonQuery();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compra where com_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        //localizar pelo código do fornecedor
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select c.com_cod,c.com_data,c.com_nfiscal," +
                "c.com_nparcelas,f.for_nome,c.com_status, c.for_cod, c.tpa_cod, c.com_total" +
                " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                " where f.for_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //lista as compras pelo nome do fornecedor
        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select c.com_cod,c.com_data,c.com_nfiscal," +
                "c.com_nparcelas,f.for_nome,c.com_status, c.for_cod, c.tpa_cod, c.com_total" +
                " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                " where f.for_nome =  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //lista todas as compras
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select c.com_cod,c.com_data,c.com_nfiscal," +
                "c.com_nparcelas,f.for_nome,c.com_status, c.for_cod, c.tpa_cod, c.com_total" +
                " from compra c inner join fornecedor f on c.for_cod = f.for_cod", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select distinct  c.com_cod,c.com_data,c.com_nfiscal,"+
                "c.com_nparcelas, f.for_nome,c.com_status, c.for_cod, c.tpa_cod, c.com_total "+
                "from compra c inner join fornecedor f on c.for_cod = f.for_cod "+
                "inner join parcelascompra p on c.com_cod = p.com_cod where p.pco_datapagto is NULL", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(com_cod) from parcelascompra where com_cod = @cod and pco_datapagto is NULL";
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
            cmd.CommandText = "Select c.com_cod,c.com_data,c.com_nfiscal," +
                "c.com_nparcelas,f.for_nome,c.com_status, c.for_cod, c.tpa_cod, c.com_total" +
                " from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                " where c.com_data BETWEEN @dtinicial and @dtfinal";

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


        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                modelo.ComNFiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                modelo.ComNParcelas = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus = Convert.ToString(registro["com_status"]);
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
