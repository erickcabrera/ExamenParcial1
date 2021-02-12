using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1
{
    public partial class Horarios_form : BaseEstilo
    {
        private int edit_indice;
        private int id_trabajador = -1;
        private int contadort = 0;
        public Horarios_form()
        {
            InitializeComponent();
        }

        private void Horarios_form_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Horario");

            //Llenando Combobox
            cbx.Items.Insert(0, "Seleccionar");
            cbx.SelectedIndex = 0;
            cn.ConsultasLlenarCBX(cbx);
        }

        //Metodos
        private void ActualizarDataGrid()
        {
            dgvmostrar.DataSource = null;
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Horario");
        }

        private void reseteo()
        {
            cbx.SelectedIndex = 0;
            cbtlunes.Checked = false;
            cbtmartes.Checked = false;
            cbtmiercoles.Checked = false;
            cbtjueves.Checked = false;
            cbtviernes.Checked = false;
            cbtsabado.Checked = false;
            cbtdomingo.Checked = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (id_trabajador != -1 && contadort == 5)
            {
                errorProvider1.Clear();
                Conexion cnn = new Conexion();
                cnn.ConsultasActualizarDia(id_trabajador);
                if (cbtlunes.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("lunes", id_trabajador);
                }
                if(cbtmartes.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("martes", id_trabajador);
                }
                if(cbtmiercoles.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("miercoles", id_trabajador);
                }
                if(cbtjueves.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("jueves", id_trabajador);
                }
                if(cbtviernes.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("viernes", id_trabajador);
                }
                if(cbtsabado.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("sabado", id_trabajador);
                }
                if(cbtdomingo.Checked == true)
                {
                    cnn = new Conexion();
                    cnn.ConsultasAgregarDia("domingo", id_trabajador);
                }
                MessageBox.Show("Horario actualizado correctamente");
                ActualizarDataGrid();
                reseteo();
                contadort = 0;
                id_trabajador = -1;
                cbx.Items.Clear();
                cbx.Items.Insert(0, "Seleccionar");
                cbx.SelectedIndex = 0;
                cnn = new Conexion();
                cnn.ConsultasLlenarCBX(cbx);
            }else if (validaciones())
            {
                try
                {
                    errorProvider1.Clear();
                    Conexion cn = new Conexion();
                    Horario horario = new Horario();

                    if (id_trabajador == -1)
                    {
                        horario.Id_trabajador = cn.ConsultasComprobacion(cbx.SelectedItem.ToString());
                        cn = new Conexion();
                        cn.ConsultasAgregarHorario(horario.Id_trabajador);
                        if (cbtlunes.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("lunes", horario.Id_trabajador);
                        }
                        if (cbtmartes.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("martes", horario.Id_trabajador);
                        }
                        if (cbtmiercoles.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("miercoles", horario.Id_trabajador);
                        }
                        if (cbtjueves.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("jueves", horario.Id_trabajador);
                        }
                        if (cbtviernes.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("viernes", horario.Id_trabajador);
                        }
                        if (cbtsabado.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("sabado", horario.Id_trabajador);
                        }
                        if (cbtdomingo.Checked == true)
                        {
                            cn = new Conexion();
                            cn.ConsultasAgregarDia("domingo", horario.Id_trabajador);
                        }
                        MessageBox.Show("Horario agregado correctamente");
                        ActualizarDataGrid();
                        reseteo();
                        contadort = 0;
                        cbx.Items.Clear();
                        cbx.Items.Insert(0, "Seleccionar");
                        cbx.SelectedIndex = 0;
                        cn.ConsultasLlenarCBX(cbx);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //CBOX para dias trabajados
        private void cbtlunes_Click(object sender, EventArgs e)
        {
            if (cbtlunes.Checked==true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtlunes.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }     
        }

        private void cbtmartes_Click(object sender, EventArgs e)
        {
            if (cbtmartes.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtmartes.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void cbtmiercoles_Click(object sender, EventArgs e)
        {
            if (cbtmiercoles.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtmiercoles.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void cbtjueves_Click(object sender, EventArgs e)
        {
            if (cbtjueves.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtjueves.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void cbtViernes_Click(object sender, EventArgs e)
        {
            if (cbtviernes.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtviernes.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void cbtsabado_Click(object sender, EventArgs e)
        {
            if (cbtsabado.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtsabado.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void cbtdomingo_Click(object sender, EventArgs e)
        {
            if (cbtdomingo.Checked == true)
            {
                if (contadort < 5)
                {
                    contadort++;
                }
                else
                {
                    cbtdomingo.Checked = false;
                    MessageBox.Show("Ya selecciono 5 días. Porfavor deseleccione uno para elegirte este");
                }
            }
            else
            {
                if (contadort > 0)
                {
                    contadort--;
                }
            }
        }

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            if (dgvmostrar.RowCount > 0)
            {
                edit_indice = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                id_trabajador = Convert.ToInt32(dgvmostrar.Rows[edit_indice].Cells[1].Value);
                //Añadiendo valores de los días de trabajo
                if (dgvmostrar.Rows[edit_indice].Cells[2].Value.ToString().Length > 0)
                {
                    cbtlunes.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[3].Value.ToString().Length > 0)
                {
                    cbtmartes.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[4].Value.ToString().Length > 0)
                {
                    cbtmiercoles.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[5].Value.ToString().Length > 0)
                {
                    cbtjueves.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[6].Value.ToString().Length > 0)
                {
                    cbtviernes.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[7].Value.ToString().Length > 0)
                {
                    cbtsabado.Checked = true;
                    contadort++;
                }
                if (dgvmostrar.Rows[edit_indice].Cells[8].Value.ToString().Length > 0)
                {
                    cbtdomingo.Checked = true;
                    contadort++;
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (id_trabajador != 0) //verifica si hay un índice seleccionado
            {
                Conexion cn = new Conexion();
                if (cn.ConsultasBorrar(id_trabajador, "Horario") == 1)
                {
                    MessageBox.Show("Registro borrado exitosamente");
                    reseteo();
                    ActualizarDataGrid();
                    cbx.Items.Clear();
                    cbx.Items.Insert(0, "Seleccionar");
                    cbx.SelectedIndex = 0;
                    cn.ConsultasLlenarCBX(cbx);
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

        //Validaciones

        private bool validaciones()
        {
            bool validado = true;
            if (cbx.SelectedIndex == 0)
            {
                validado = false;
                errorProvider1.SetError(cbx, "Por favor escoja un empleado");
            }
            if (contadort != 5)
            {
                validado = false;
                errorProvider1.SetError(lbdtrabajo, "Debe seleccionar 5 dias de trabajo");
            }
            return validado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            MessageBox.Show(cn.ConsultasComprobacion(cbx.SelectedItem.ToString()).ToString());

        }
    }
}
 