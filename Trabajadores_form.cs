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
    public partial class Trabajadores_form : BaseEstilo
    {
        private int edit_indice = -1;
        private int id_trabajador = 0;
        private int cantidad = 0;
        private int fecha_seleccionada = 0;
        public Trabajadores_form()
        {
            InitializeComponent();
        }
        private void Gerente_Platform_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Trabajador");
            cantidad = dgvmostrar.RowCount;
            cbtipo.SelectedIndex = 0;
        }
        
        //Metodos
        private void ActualizarDataGrid()
        {
            dgvmostrar.DataSource = null;
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Trabajador");
        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtafp.Clear();
            txtdireccion.Clear();
            txtdui.Clear();
            txtnit.Clear();
            txtpago.Clear();
            txtseguro.Clear();
            txttelefono.Clear();
            fechanacimiento.SelectionStart = DateTime.Today;
            cbtipo.SelectedIndex = 0;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                Conexion cn = new Conexion();
                Trabajadores trabajador = new Trabajadores();
                trabajador.Nombre = txtnombre.Text;
                trabajador.Telefono = txttelefono.Text;
                trabajador.Tipo = Convert.ToString(cbtipo.SelectedItem);
                trabajador.Dui = txtdui.Text;
                trabajador.Afp = txtafp.Text;
                trabajador.Seguro = txtseguro.Text;
                trabajador.Nit = txtnit.Text;
                trabajador.Direccion = txtdireccion.Text;
                trabajador.Pago = float.Parse((txtpago.Text));
                DateTime fecha = fechanacimiento.SelectionStart;
                trabajador.Fecha = fecha;

                if (id_trabajador != 0)
                {

                    if (cn.ConsultasActualizar(trabajador, id_trabajador) == 0)
                    {
                        MessageBox.Show("No se pudo actualizar en la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Datos actualizados");
                        ActualizarDataGrid();
                        reseteo();
                        id_trabajador = 0;
                    }
                }
                else
                {
                    Conexion cn2 = new Conexion();
                    if (cn2.ConsultasInsertar(trabajador) == 0)
                    {
                        MessageBox.Show("No se pudo ingresar a la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        ActualizarDataGrid();
                        reseteo();
                        id_trabajador = 0;
                    }
                }
            }     
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                if (id_trabajador != 0) //verifica si hay un índice seleccionado
                {
                    Conexion cn = new Conexion();
                    if (cn.ConsultasBorrar(id_trabajador, "Trabajador") == 1)
                    {
                        MessageBox.Show("Registro borrado exitosamente");
                        reseteo();
                        ActualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al borrar el registro");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de datos primero");
                }
            }
        }

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            if (dgvmostrar.Rows.Count > 0)
            {
                edit_indice = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                id_trabajador = Convert.ToInt32(dgvmostrar.Rows[edit_indice].Cells[0].Value);
                txtnombre.Text = dgvmostrar.Rows[edit_indice].Cells[1].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgvmostrar.Rows[edit_indice].Cells[2].Value);
                fechanacimiento.SelectionStart = fecha;
                fechanacimiento.SelectionEnd = fecha;
                txtdui.Text = dgvmostrar.Rows[edit_indice].Cells[3].Value.ToString();
                txtnit.Text = dgvmostrar.Rows[edit_indice].Cells[4].Value.ToString();
                txtafp.Text = dgvmostrar.Rows[edit_indice].Cells[5].Value.ToString();
                txtseguro.Text = dgvmostrar.Rows[edit_indice].Cells[6].Value.ToString();
                txtdireccion.Text = dgvmostrar.Rows[edit_indice].Cells[7].Value.ToString();
                txtpago.Text = Convert.ToString(dgvmostrar.Rows[edit_indice].Cells[8].Value);
                txttelefono.Text = dgvmostrar.Rows[edit_indice].Cells[9].Value.ToString();
                cbtipo.SelectedItem = dgvmostrar.Rows[edit_indice].Cells[10].Value.ToString();
            }
        }

        //Validaciones

        private bool validaciones()
        {
            bool validado = true;
            if (txtnombre.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtnombre, "Agregar dato");
            }
            if (txtdui.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtdui, "Agregar dato");
            }
            if (txtnit.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtnit, "Agregar dato");
            }
            if (txtafp.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtafp, "Agregar dato");
            }
            if (txtseguro.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtseguro, "Agregar dato");
            }
            if (txtdireccion.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtdireccion, "Agregar dato");
            }
            if (txtpago.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtpago, "Agregar dato");
            }
            if (txttelefono.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txttelefono, "Agregar dato");
            }
            if (fecha_seleccionada == 0)
            {
                validado = false;
                errorProvider1.SetError(fechanacimiento, "Seleccionar fecha");
            }
            return validado;
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtseguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "validación de numeros",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para punto 
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtdui_Click(object sender, EventArgs e)
        {
            if (id_trabajador == 0)
            {
                txtdui.Clear();
            }
        }

        private void txtnit_Click(object sender, EventArgs e)
        {
            if (id_trabajador == 0)
            {
                txtnit.Clear();
            }
        }

        private void txtafp_Click(object sender, EventArgs e)
        {
            if (id_trabajador == 0)
            {
                txtafp.Clear();
            }
        }
        private void txttelefono_Click(object sender, EventArgs e)
        {
            if (id_trabajador == 0)
            {
                txttelefono.Clear();
            }
        }
        private void fechanacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (fechanacimiento.SelectionStart > DateTime.Now)
            {
                MessageBox.Show("Fecha seleccionada no valida");
                fechanacimiento.SelectionStart = DateTime.Now;
                fechanacimiento.SelectionEnd = DateTime.Now;
            }
            else
            {
                fecha_seleccionada = 1;
            }
        }
    }
}
