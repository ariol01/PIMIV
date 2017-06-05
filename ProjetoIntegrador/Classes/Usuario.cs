using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.DAO;


namespace ProjetoIntegrador.Classes
{
   public class Usuario
    {
        private int id;
        private string nome;
        private string cpf;
        private string cep;
        private string rua;
        private string numero;
        private string telefone;
        private string senha;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
     public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public void Gravar()
        {
            UsuarioDAO udao = new UsuarioDAO();
            udao.Inserir(this);

        }

        public Usuario BuscarID(string descricao)
        {
            UsuarioDAO udao = new UsuarioDAO();
            Usuario u = new Usuario();
            u = udao.SelecionarID(descricao);
            return u;

        }

        public Usuario BuscarSenhaLogin(Usuario u)
        {
            UsuarioDAO udao = new UsuarioDAO();

            Usuario obju = new Usuario();
            obju = udao.SelecionarLoginSenha(u);

            return obju;
            

        }

        

        }
      

    }

