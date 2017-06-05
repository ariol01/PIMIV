using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProjetoIntegrador.Formularios;
using ProjetoIntegrador.Classes;

namespace ProjetoIntegrador.Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            bool abrir = false;

            t.Start();
            abrir = true;
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();



        }


        public void SplashStart()
        {
            Application.Run(new FormInicializacao());

        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInscricao FmInscricao = new FormInscricao();
            FmInscricao.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            try
            {

                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(txtIdLogin.Text);
                usuario.Senha = txtSenha.Text;

                Usuario u2 = new Usuario();
                u2 = u2.BuscarSenhaLogin(usuario);


                if (usuario.Id == u2.Id && usuario.Senha == u2.Senha)
                {

                    this.Hide();
                    FormMenu t = new FormMenu();
                    t.Show();
                }





            }
            catch (Exception)
            {

                MessageBox.Show(" SENHA OU LOGIN ESTAO ERRADOS!!");


            }




        }


    }
}
