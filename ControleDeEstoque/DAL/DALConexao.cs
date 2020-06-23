using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        private SqlTransaction _transaction;
        
        public DALConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public SqlTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }
        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }
        //desfaz tudo o que fez
        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
