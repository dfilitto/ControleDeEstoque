using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLParcelasCompra
    {
        private DALConexao conexao;
        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void EfetuaPagamentoParcela(int comCod, int pcoCod, DateTime dtpagto)
        {
            if (dtpagto != null)
            {
                DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
                DALobj.EfetuaPagamentoParcela(comCod, pcoCod, dtpagto);
            }
            else { throw new Exception("Data de pagamento obrigatória"); }
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodasAsParcelas(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
           
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirTodasAsParcelas(comcod);
        }
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(PcoCod,ComCod);
        }
    }
}
