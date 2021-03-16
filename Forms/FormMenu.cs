using ExamenParcial1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntrabajadores_Click(object sender, EventArgs e)
        {
            FormTrabajadores form = new FormTrabajadores();
            form.Show();
            this.Hide();
        }

        private void btnplanillas_Click(object sender, EventArgs e)
        {
            /*Planilla_form form = new Planilla_form();
            form.Show();
            this.Hide();*/
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            FormInventario form = new FormInventario();
            form.Show();
            this.Hide();
        }

        private void btnhorarios_Click(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormFactura form = new FormFactura();
            form.Show();
            this.Hide();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }
    }
}
