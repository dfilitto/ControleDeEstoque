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
    public class BLLItensCompra
    {
        private DALConexao conexao;
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);

        }
        public void ExcluirTodosOsItens(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.ExcluirTodosOsItens(comcod);
        }

        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ItcCod, ComCod, ProCod);
        }
    }
}
