using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Classes;

namespace ProjetoIntegrador.Classes
{
    public class Pizza
    {
        private int id;
        private string nome;
        private string tamanho;
        private Igredientes objingrediente;
        
        public Pizza (Sabores sabor)
        {

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

     

        public string Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

      
    }
}
