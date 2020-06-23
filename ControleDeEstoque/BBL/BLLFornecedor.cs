using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using Ferramentas;
using System.Data;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório");
            }

            
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O CNPJ inválido");
            }
          
            //verificar CPF/CNPJ

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            // For_tipo = 0 -> fisica
            // For_tipo = 1 -> juridica

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório");
            }

            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O CNPJ inválido");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }
        public DataTable LocalizarPorCNPJ(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }
    }
}
