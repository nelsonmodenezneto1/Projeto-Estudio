using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio1
{
    class DAO_Conexao
    {
        private static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server="+local+";User ID=" +user+";database="+banco+";password="+senha);
                //con.Open();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //con.Close()://ajustar
            }
            finally
            {
                //con.Close();
            }
            return retorno;
        }
        public static int login(String usuario, String senha)
        {
            int tipo = 0;
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("select * from Estudio_Login where usuario ='" + usuario + "' and senha='"+senha+"'",con);
                MySqlDataReader resultado = login.ExecuteReader();
                if(resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
        public static int CadLogin(String usuario, String senha)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Login (usuario, senha, tipo) values ('"+ usuario +"','"+ senha +"'," + tipo +")");
                MySqlDataReader resultado = login.ExecuteReader();
                cad = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
}
