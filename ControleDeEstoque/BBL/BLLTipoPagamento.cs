using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLTipoPagamento
    {
        private DALConexao conexao;
        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo do pagamento é obrigatório");
            }

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo do pagamento é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPagamento(codigo);
        }
    }
}
