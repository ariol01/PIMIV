using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoIntegrador.Classes;

namespace ProjetoIntegrador.DAO
{
    public class EnderecoPizzaDAO
    {
        public void Inserir (EnderecoPizza end)
        {
            SqlCommand c = new SqlCommand();
            c.CommandType = System.Data.CommandType.Text;
            c.CommandText = "insert into EnderecoPizza (numero, bairro, complemento)values (@numero, @bairro, @complemento)";
            c.Parameters.AddWithValue ("@numero", end.Numero);
            c.Parameters.AddWithValue("@bairro", end.Bairro);
            c.Parameters.AddWithValue("@complemento", end.Complemento);

            ConexaoDAO con = new ConexaoDAO();
            con.CRUD(c);
        }

    }
}
