using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoIntegrador.Classes;
using System.Data;

namespace ProjetoIntegrador.DAO
{
  public  class UsuarioDAO
    {
        public void Inserir (Usuario u)
        {
            SqlCommand c = new SqlCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = "insert into tbl_usuario (nome, cpf,senha,cep,rua,numero,telefone ) values (@nome,@cpf, @senha,@cep,@rua,@numero,@telefone)";
            c.Parameters.AddWithValue  ("@nome", u.Nome);
            c.Parameters.AddWithValue("@cpf",u.Cpf);
            c.Parameters.AddWithValue("@senha", u.Senha);
            c.Parameters.AddWithValue("@cep", u.Cep);
            c.Parameters.AddWithValue("@rua", u.Rua);
            c.Parameters.AddWithValue("@numero", u.Numero);
            c.Parameters.AddWithValue("@telefone", u.Telefone);
            
            ConexaoDAO con = new ConexaoDAO();
            con.CRUD(c); 
        }


        public Usuario SelecionarID( string s)
        {
            SqlCommand c = new SqlCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = " select id from tbl_usuario where cpf = @cpf ";
            c.Parameters.AddWithValue("@cpf", s);

            ConexaoDAO con = new ConexaoDAO();

            SqlDataReader dr = con.Select(c);
            Usuario u = new Usuario();

            if (dr.HasRows)
            {
                dr.Read();

                u.Id = Convert.ToInt32( dr["id"]);

            }
            else
            {
                return u = null;
            }

            return u;

        }

        public Usuario SelecionarLoginSenha(Usuario u)
        {
            SqlCommand c = new SqlCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = "select  id,senha from tbl_usuario  where id = @id and senha = @senha ";
            c.Parameters.AddWithValue("@id", u.Id);
            c.Parameters.AddWithValue("@senha", u.Senha);

            ConexaoDAO con = new ConexaoDAO();

            SqlDataReader dr = con.Select(c);

            
            Usuario obju = new Usuario();

            if (dr.HasRows)
            {
                dr.Read();
                
                obju.Id = Convert.ToInt32(dr["id"]);
                obju.Senha = Convert.ToString(dr["senha"]);
                                
            }
            else
            {
                return obju = null;
            }

            return obju;


        }


    }
}
