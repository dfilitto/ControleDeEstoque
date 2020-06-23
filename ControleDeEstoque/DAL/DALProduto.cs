using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using System.Data;


namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Produto (pro_nome, pro_descricao, pro_foto,  pro_valorpago, pro_valorvenda, pro_qtde,umed_cod , cat_cod, scat_cod) "+
            "values (@nome,@descricao,@foto,@valorpago,@valorvenda,@qtde,@undmedcod,@catcod,@scatcod); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", obj.ProNome);
            cmd.Parameters.AddWithValue("@descricao", obj.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pro_foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", obj.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", obj.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", obj.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", obj.ScatCod);
            conexao.Conectar();
            obj.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Produto where (pro_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloProduto obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto SET pro_nome = (@nome), pro_descricao = (@descricao), "+
                "pro_foto = (@foto), pro_valorpago = (@valorpago), pro_valorvenda = (@valorvenda), "+
                "pro_qtde = (@qtde), umed_cod = (@undmedcod), cat_cod = (@catcod), "+
                "scat_cod = (@scatcod) WHERE pro_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", obj.ProNome);
            cmd.Parameters.AddWithValue("@descricao", obj.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", obj.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", obj.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", obj.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", obj.ScatCod);
            cmd.Parameters.AddWithValue("@codigo", obj.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto obj, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto SET pro_nome = (@nome), pro_descricao = (@descricao), " +
                "pro_foto = (@foto), pro_valorpago = (@valorpago), pro_valorvenda = (@valorvenda), " +
                "pro_qtde = (@qtde), umed_cod = (@undmedcod), cat_cod = (@catcod), " +
                "scat_cod = (@scatcod) WHERE pro_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", obj.ProNome);
            cmd.Parameters.AddWithValue("@descricao", obj.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", obj.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", obj.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", obj.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", obj.ScatCod);
            cmd.Parameters.AddWithValue("@codigo", obj.ProCod);         
            if(transacao)
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, "+
"p.pro_valorvenda, p.pro_qtde, p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome "+
 "from Produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod "+
  "inner join subcategoria sc on p.scat_cod = sc.scat_cod  where p.pro_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Produto where pro_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["pro_foto"];

                }
                catch { }
                modelo.ProValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloProduto CarregaModeloProduto(int codigo, Boolean transacao)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Produto where pro_cod =" + codigo.ToString();
            if (transacao == false)
            {
                conexao.Conectar();
            }
            else
            {
                cmd.Transaction = conexao.ObjetoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["pro_foto"];

                }
                catch { }
                modelo.ProValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
            }
            registro.Close();
            if (transacao == false) conexao.Desconectar();
            return modelo;
        }
    }
}
