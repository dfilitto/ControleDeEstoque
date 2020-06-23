using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        public ModeloParcelasVenda()
        {
            this.PveCod = 0;
            this.PveValor = 0;
            this.VenCod = 0;
            this.PveDataPagto = DateTime.Now;
            this.PveDataVecto = DateTime.Now;
        }

        private int pve_cod;
        public int PveCod
        {
            get { return this.pve_cod; }
            set { this.pve_cod = value; }
        }

        private int ven_cod;
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        private Double pve_valor;
        public Double PveValor
        {
            get { return this.pve_valor; }
            set { this.pve_valor = value; }
        }

        private DateTime pve_datapagto;
        public DateTime PveDataPagto
        {
            get { return this.pve_datapagto; }
            set { this.pve_datapagto = value; }
        }

        private DateTime pve_datavecto;
        public DateTime PveDataVecto
        {
            get { return this.pve_datavecto; }
            set { this.pve_datavecto = value; }
        }
    }
}
