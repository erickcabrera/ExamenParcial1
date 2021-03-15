using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1
{
    public partial class Factura_mostrar : Form
    {
        public Factura_mostrar()
        {
            InitializeComponent();
        }

        private void Factura_mostrar_Load(object sender, EventArgs e)
        {
            /*
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Factura");
            */
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Factura_form form = new Factura_form();
            form.Show();
            this.Hide();
        }
    }
}
