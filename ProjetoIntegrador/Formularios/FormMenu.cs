using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Formularios;

namespace ProjetoIntegrador.Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        bool flag = true;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (flag == true)
            Environment.Exit(0);
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal FomrPrincipal1 = new FormPrincipal();
            FomrPrincipal1.MdiParent = this;
            FomrPrincipal1.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscricao frmi = new FormInscricao();
            frmi.MdiParent = this;
            frmi.Show();
        }
    }
}
