using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Classes
{
   public  class Pedido
    {
        private DateTime datapedido;
        private double precototal;
        private int quantidade;
        private Pizza objpizza;
        private EnderecoPizza objendereco;
        private Sabores objsabores;
        private Igredientes objingredientes;

        public DateTime Datapedido
        {
            get
            {
                return datapedido;
            }

            set
            {
                datapedido = value;
            }
        }

        public double Precototal
        {
            get
            {
                return precototal;
            }

            set
            {
                precototal = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public Pizza Objpizza
        {
            get
            {
                return objpizza;
            }

            set
            {
                objpizza = value;
            }
        }

        public EnderecoPizza Objendereco
        {
            get
            {
                return objendereco;
            }

            set
            {
                objendereco = value;
            }
        }

        public Sabores Objsabores
        {
            get
            {
                return objsabores;
            }

            set
            {
                objsabores = value;
            }
        }

        public Igredientes Objingredientes
        {
            get
            {
                return objingredientes;
            }

            set
            {
                objingredientes = value;
            }
        }
    }
}
