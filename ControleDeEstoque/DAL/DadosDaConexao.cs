using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DELXP\SQLEXPRESS";
        public static String banco = "ControleDeEstoque";
        public static String usuario = "sa";
        public static String senha = "123456";
        public static String StringDeConexao
        {
            get 
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
}
