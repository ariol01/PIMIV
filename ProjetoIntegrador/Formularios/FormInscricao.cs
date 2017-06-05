using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Classes;
using ProjetoIntegrador.Formularios;

namespace ProjetoIntegrador.Formularios
{
    public partial class FormInscricao : Form
    {
        public FormInscricao()
        {
            
            InitializeComponent();
          
        }

        private void bttSalvarCadastro_Click(object sender, EventArgs e)
        {
           
            {

                try
                {
                    Usuario usuario = new Usuario();
                    usuario.Nome = txtNomeCompleto.Text;
                    usuario.Cpf = msktxtboxCpf.Text;

                    usuario.Cep = msktxtboxCep.Text;

                    usuario.Rua = txtRua.Text;
                    usuario.Numero = msktxtboxNumero.Text;

                    usuario.Telefone = msktxtboxTelefone.Text;

                    usuario.Senha = txtCadastrarSenha.Text;
                    usuario.Gravar();                   
                    usuario = usuario.BuscarID(usuario.Cpf);
                    




                    MessageBox.Show("Cadastrado com sucesso. SUA ID ''" + usuario.Id +" '' ");
                  
                   
                    string MessageBoxTitle = "ALERTA";
                    string MessageBoxContent = "Deseja Cadastrar outro Usuario ?";

                    DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        txtNomeCompleto.Text = "";
                        msktxtboxCpf.Text = "";
                        msktxtboxCep.Text = "";
                        txtRua.Text = "";
                        msktxtboxNumero.Text = "";
                        msktxtboxTelefone.Text = "";
                        txtCadastrarSenha.Text = "";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        this.Hide();
                        FormLogin flogin = new FormLogin();
                        flogin.Show();
                        
                    }






                    //u.BuscarID(u.Cpf); // fazer verificacao pra n cadastrar mesmo cpf(trigger)
                    //txtID.Text = Convert.ToString(u.Id);


                }
                catch (Exception erro)
                {
                    throw erro;
                    
                  
                }
               
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola");
            FormLogin flogin = new FormLogin();
            flogin.Show();
        }
    }
}
