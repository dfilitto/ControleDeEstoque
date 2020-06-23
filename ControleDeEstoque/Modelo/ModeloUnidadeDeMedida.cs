using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        //umed_cod
        //umed_nome

        public ModeloUnidadeDeMedida()
        {
            this.UmedCod = 0;
            this.UmedNome = "";
        }

        public ModeloUnidadeDeMedida(int cod, String nome)
        {
            this.UmedCod = cod;
            this.UmedNome = nome;
        }

        private int umed_cod;
        public int UmedCod
        {
            get
            {
                return this.umed_cod;
            }
            set
            {
                this.umed_cod = value;
            }
        }
        private String umed_nome;
        public String UmedNome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }
    }
}
