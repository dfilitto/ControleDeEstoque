using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
         //construtores
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRSocial = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCelular = "";
            this.ForEmail = "";
            this.ForEndNumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        public ModeloFornecedor(int cod, string nome, string cpfcnpj, string rgie,
            string rsocial, string cep, string endereco, string bairro,
            string fone, string celular, string email, string endnumero, 
            string cidade, string estado)
        {
            this.ForCod = cod;
            this.ForNome = nome;
            this.ForCnpj = cpfcnpj;
            this.ForIe = rgie;
            this.ForRSocial = rsocial;
            this.ForCep = cep;
            this.ForEndereco = endereco;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCelular = celular;
            this.ForEmail = email;
            this.ForEndNumero = endnumero;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }
        //propriedades da  classe
        private int For_cod;
        public int ForCod
        {
            get { return this.For_cod; }
            set { this.For_cod = value; }
        }

        private string For_nome;
        public string ForNome
        {
            get { return this.For_nome; }
            set { this.For_nome = value; }
        }

        private string For_cnpj;
        public string ForCnpj
        {
            get { return this.For_cnpj; }
            set { this.For_cnpj = value; }
        }

        private string For_Ie;
        public string ForIe
        {
            get { return this.For_Ie; }
            set { this.For_Ie = value; }
        }

        private string For_RSocial;
        public string ForRSocial
        {
            get { return this.For_RSocial; }
            set { this.For_RSocial = value; }
        }

        private string For_cep;
        public string ForCep
        {
            get { return this.For_cep; }
            set { this.For_cep = value; }
        }

        private string For_endereco;
        public string ForEndereco
        {
            get { return this.For_endereco; }
            set { this.For_endereco = value; }
        }

        private string For_bairro;
        public string ForBairro
        {
            get { return this.For_bairro; }
            set { this.For_bairro = value; }
        }

        private string For_fone;
        public string ForFone
        {
            get { return this.For_fone; }
            set { this.For_fone = value; }
        }

        private string For_cel;
        public string ForCelular
        {
            get { return this.For_cel; }
            set { this.For_cel = value; }
        }

        private string For_email;
        public string ForEmail
        {
            get { return this.For_email; }
            set { this.For_email = value; }
        }

        private string For_endnumero;
        public string ForEndNumero
        {
            get { return this.For_endnumero; }
            set { this.For_endnumero = value; }
        }

        private string For_cidade;
        public string ForCidade
        {
            get { return this.For_cidade; }
            set { this.For_cidade = value; }
        }

        private string For_estado;
        public string ForEstado
        {
            get { return this.For_estado; }
            set { this.For_estado = value; }
        }
    }
    
}
