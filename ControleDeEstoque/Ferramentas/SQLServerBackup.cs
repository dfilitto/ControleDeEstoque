using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class SQLServerBackup
    {
        public static ArrayList ObtemBancoDeDadosSQLSever(String ConnString)
        {
            ArrayList lista = new ArrayList();
            //criou a conexao
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SELECT [name] FROM sysdatabases";
            //criou o datareader
            SqlDataReader dr;
            try
            {
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["name"]);
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }

        public static void BackupDataBase(String ConnString, string nomeDB, string backupFile)
        {
            //string backup="";
            //criou a conexao
            SqlConnection.ClearAllPools();
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "BACKUP DATABASE [" + nomeDB + "] TO DISK = '" + backupFile + "'";
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            //return backup;

        }

        public static void RestauraDatabase(String ConnString, string nomeDB, string backupFile)
        {
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            string sql = "RESTORE DATABASE [" + nomeDB + "] FROM DISK = '" + backupFile + "'  WITH REPLACE";
            cm.CommandText = sql;
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            //return backup;
        }
    }
}
