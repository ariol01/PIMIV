using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoIntegrador.DAO
{
   public class ConexaoDAO
    {
        private SqlConnection Conectar()
        {
            string stringConexao = "data source = DESKTOP-JORER8B ; initial catalog = SistemaPizza; user ID = SA ; password = toor1234";
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public void CRUD (SqlCommand Comando)
        {
            SqlConnection con = Conectar();
            Comando.Connection = con;
            Comando.ExecuteNonQuery();
            con.Close();
        }


        public SqlDataReader Select (SqlCommand Comando)
        {
            SqlConnection con = Conectar();
            Comando.Connection = con;
            SqlDataReader DR = Comando.ExecuteReader(CommandBehavior.CloseConnection);
            return DR;
        }

        public int ManterCRUDComRetorno(SqlCommand Comando)
        {
            SqlConnection con = Conectar();
           
            try
            {
                bool inserir = false;
                int retorno = 0;
                if (Comando.CommandText.Contains("Insert into"))
                {
                    inserir = true;
                }
                Comando.Connection = con;
                if (inserir)
                {

                    Comando.CommandText = Comando.CommandText + ";select cast (scope_identity() as int);";
                    retorno = Convert.ToInt32(Comando.ExecuteScalar());


                }
                else
                {
                    retorno = Comando.ExecuteNonQuery();
                }
                con.Close();
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
            
    }
}
