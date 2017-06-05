using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Formularios
{
    public partial class FormInicializacao : Form
    {
        public FormInicializacao()
        {
            InitializeComponent();
           
        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pbInicializacao.Increment(1);
            if (pbInicializacao.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}
