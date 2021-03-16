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
            FormFactura form = new FormFactura();
            form.Show();
            this.Hide();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {

        }
    }
}
