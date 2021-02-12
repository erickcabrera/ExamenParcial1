using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1
{
    public partial class Planilla_form : BaseEstilo
    {
        private int edit_indice = -1;
        private int id_planilla = 0;
        private int cantidad = 0;
        private bool seleccionado = false;
        private bool seleccionado2 = false;
        public Planilla_form()
        {
            InitializeComponent();
        }

        //Metodos

        private void ActualizarDataGrid()
        {
            dgvmostrar.DataSource = null;
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Planilla");
        } 

        private void reseteo()
        {
            cbx.SelectedIndex = 0;
            calendar1.SelectionStart = DateTime.Now;
            calendar2.ShowToday = false;
            txtdiastrabajados.Clear();
        }

        private void Planilla_form_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Planilla");
            cantidad = dgvmostrar.RowCount;

            //Llenando Combobox
            cbx.Items.Insert(0, "Seleccionar");
            cbx.SelectedIndex = 0;
            cn.ConsultasLlenarCBX(cbx);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                errorProvider1.Clear();
                Planilla planilla = new Planilla();
                planilla.Id_trabajador = cbx.SelectedIndex;
                planilla.Dias_trabajados = Int32.Parse(txtdiastrabajados.Text);
                DateTime fecha = calendar1.SelectionStart.Date;
                planilla.Fecha_inicio = fecha;
                planilla.Fecha_final = calendar2.SelectionStart;
                planilla.Pago = float.Parse(txtpago.Text);

                Conexion cn = new Conexion();

                if (id_planilla != 0)
                {

                    if (cn.ConsultasActualizarPlanilla(planilla, id_planilla) == 0)
                    {
                        MessageBox.Show("No se pudo actualizar en la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Datos actualizados");
                        ActualizarDataGrid();
                        reseteo();
                        id_planilla = 0;
                    }
                }
                else
                {
                    //Pendiente agregar metodo de insertar
                    if (cn.ConsultasInsertarPlanilla(planilla) == 0)
                    {
                        MessageBox.Show("No se pudo ingresar a la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        ActualizarDataGrid();
                        reseteo();
                        id_planilla = 0;
                    }
                } 
            }
        }

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            if (dgvmostrar.Rows.Count > 0)
            {
                edit_indice = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                id_planilla = Convert.ToInt32(dgvmostrar.Rows[edit_indice].Cells[0].Value);
                cbx.SelectedIndex = Convert.ToInt32(dgvmostrar.Rows[edit_indice].Cells[1].Value);
                txtdiastrabajados.Text = dgvmostrar.Rows[edit_indice].Cells[2].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgvmostrar.Rows[edit_indice].Cells[3].Value);
                calendar1.SelectionStart = fecha;
                calendar1.SelectionEnd = fecha;
                fecha = Convert.ToDateTime(dgvmostrar.Rows[edit_indice].Cells[4].Value);
                calendar2.SelectionStart = fecha;
                calendar2.SelectionEnd = fecha;
            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                errorProvider1.Clear();
                if (id_planilla != 0) //verifica si hay un índice seleccionado
                {
                    Conexion cn = new Conexion();
                    if (cn.ConsultasBorrar(id_planilla, "Planilla") == 1)
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

        private void cbx_DropDownClosed(object sender, EventArgs e)
        {
            if (cbx.SelectedIndex != 0)
            {
                Conexion cn = new Conexion();
                cn.ConsultasObtenerPago(txtpago, cbx.SelectedIndex);
            }
        }

        //Validaciones

        private bool validaciones()
        {
            bool validado = true;
            if (txtdiastrabajados.TextLength == 0)
            {
                validado = false;
                errorProvider1.SetError(txtdiastrabajados, "Agregar dato");
            }
            if (int.Parse(txtdiastrabajados.Text) > 30)
            {
                validado = false;
                errorProvider1.SetError(txtdiastrabajados, "No puede agregar más de 30 días por periodo");
            }
            if (int.Parse(txtdiastrabajados.Text) > (Convert.ToInt32(calendar2.SelectionStart.Day) - Convert.ToInt32(calendar1.SelectionStart.Day)))
            {
                validado = false;
                errorProvider1.SetError(txtdiastrabajados, "No puede agregar más días trabajados que el rango seleccionado en el calendario");
            }
            if (seleccionado == false)
            {
                validado = false;
                errorProvider1.SetError(calendar1, "Seleccionar fecha");
            }
            if (seleccionado2 == false)
            {
                validado = false;
                errorProvider1.SetError(calendar2, "Seleccionar fecha");
            }
            if (cbx.SelectedIndex == 0)
            {
                validado = false;
                errorProvider1.SetError(cbx, "Seleccionar un empleado");
            }
            return validado;
        }
        private bool validarfecha(MonthCalendar calendar)
        {
            bool validado = true;
            if(calendar.SelectionStart > DateTime.Now)
            {
                MessageBox.Show("Fecha invalida");
                calendar.SelectionStart = DateTime.Now;
                calendar.SelectionEnd = DateTime.Now;
                validado = false;
            }else if (calendar1.SelectionStart.Month != calendar2.SelectionStart.Month)
            {
                MessageBox.Show("La fecha de inicio y la fecha final deben permanecer al mismo mes");
                calendar.SelectionStart = DateTime.Now;
                calendar.SelectionEnd = DateTime.Now;
                validado = false;
            }
            return validado;
        }
        private void txtdiastrabajados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "validación de texto",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtdiastrabajados_Click(object sender, EventArgs e)
        {
            txtdiastrabajados.Clear();
        }

        private void calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (validarfecha(calendar1))
            {
                seleccionado = true;
            }
        }

        private void calendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (validarfecha(calendar1))
            {
                seleccionado2 = true;
            }
        }
        
    }
}
