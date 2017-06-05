using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Classes;

namespace ProjetoIntegrador.Classes
{
   public class EnderecoPizza
    {
        private string numero;
        private string bairro;
        private string complemento;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
    }
}
