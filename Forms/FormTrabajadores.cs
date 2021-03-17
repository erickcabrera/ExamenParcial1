using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SistemaInventario
{
    public partial class FormTrabajadores : Form
    {
        private int id_trabajador = 0;
        private int fecha_seleccionada = 0;
        //El validador me permite saber si un dato va a ser ingresado, o caso contrario, va a ser modificado
        private int validador = -1;
        private string dui = "";
        ListaTrabajador lista = new ListaTrabajador();

        public FormTrabajadores()
        {
            InitializeComponent();
        }

        //Metodos

        //El metodo tiene como parametro un objeto de tipo lista. El cual luego ocupo el método Mostrar la Lista
        //Esto me devuelve una cola y la uso como DataSource
        private void ActualizarDataGrid(ListaTrabajador lista)
        {
            dgvmostrar.DataSource = null;
            dgvmostrar.DataSource = lista.Mostrar().ToList();
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
            try
            {
                //Faltan validaciones
                //Ahorita no las he activado porque sino hay que ingresar toooodos estos datos y es tedioso para hacer pruebas

                //Creo un objeto del tipo trabajador y lleno los datos de este
                Trabajadores trabajador = new Trabajadores();
                trabajador.Nombre = txtnombre.Text;
                trabajador.Dui = txtdui.Text;
                trabajador.Nit = txtnit.Text;
                trabajador.Afp = txtafp.Text;
                trabajador.Seguro = txtseguro.Text;
                trabajador.Direccion = txtdireccion.Text;
                trabajador.Telefono = txttelefono.Text;
                trabajador.Tipo = cbtipo.SelectedItem.ToString();
                trabajador.Pago = float.Parse(txtpago.Text);
                trabajador.Fecha = fechanacimiento.SelectionStart;

                //Si el validador == -1 significa que un dato será INGRESADO
                if (validador == -1)
                {
                    //De ser así, ocupo el método InsertarF y le mando el objeto de tipo trabajador
                    lista.InsertarF(trabajador);
                    //Actualizo el datagrid mandandole la lista con el nuevo dato ingresado
                    ActualizarDataGrid(lista);
                    //Limpio pantalla
                    reseteo();
                }
                else
                {
                    //Caso contrario, significa que el usuario está modificando un trabajador existente
                    //Hago que estos campos ahora sean modificables para cuando quiere ingresar un nuevo dato
                    txtdui.ReadOnly = false;
                    txtafp.ReadOnly = false;
                    txtnit.ReadOnly = false;
                    txtseguro.ReadOnly = false;
                    //Ocupo el método editar y le mando como parametro el DUI del trabajador a modificar y el objeto de tipo trabajador
                    lista.Editar(dui, trabajador);
                    //Actualizo el datagrid
                    ActualizarDataGrid(lista);
                    reseteo();
                    //Hago que el validador sea nuevamente -1 y el dui le doy un valor nulo
                    validador = -1;
                    dui = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            //Faltan validaciones

            //Pruebo si ha sido seleccionado un dato del datagrid
            if (validador != -1)
            {
                try
                {
                    //Esto lo tenía para ver que el dato correcto se estaba borrando  MessageBox.Show(dui);

                    //Creo un nuevo objeto del tipo lista
                    ListaTrabajador lista2 = new ListaTrabajador();

                    //Le paso todos los valores que no sean los que se quieren borrar de la lista global
                    foreach (Trabajadores trabajador in lista.EnCola(dui))
                    {
                        lista2.InsertarF(trabajador);
                    }
                    //Hago que la lista global sea igual a la nueva lista, es decir, que tenga los valores nuevos excepto el borrado
                    lista = lista2;
                    //Actualizo el datagrid
                    ActualizarDataGrid(lista);
                    //Reinicio los validadores
                    validador = -1;
                    reseteo();
                    dui = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una row primero");
            }
        }

        DataView ImportarDatos(string nombrearchivo)
        {
            //Este código lo copié de internet, pero le entiendo. Lo que importa es que funciona
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nombrearchivo);

            OleDbConnection conector = new OleDbConnection(conexion);

            conector.Open();

            //Asegurense que el documento excel que van a importar tenga Hoja1 como nombre. No Hoja 1, debe estar unido Hoja1
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            conector.Close();

            return ds.Tables[0].DefaultView;
        }

        public void ExportarDatos(DataGridView gridIn, string outputFile)
        {
            //Tambien lo copié de internet. Este exportar en formato .csv, ya que me dio problemas con una libreria al intentar
            //Exportar el excel de un solo

            //El archivo .csv, lo pueden abrir desde excel y luego guardarlo así, para luego volverlo a importar a este programa
            //prueba para ver si DataGridView tiene alguna fila
            try
            {
                if (gridIn.RowCount > 0)
                {
                    string value = "";
                    DataGridViewRow dr = new DataGridViewRow();
                    StreamWriter swOut = new StreamWriter(outputFile);

                    //escribir filas de encabezado en csv
                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }
                        swOut.Write(gridIn.Columns[i].HeaderText);
                    }

                    swOut.WriteLine();

                    //escribir filas DataGridView en csv
                    for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            swOut.WriteLine();
                        }

                        dr = gridIn.Rows[j];

                        for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                swOut.Write(",");
                            }

                            value = dr.Cells[i].Value.ToString();
                            //reemplazar comas con espacios
                            value = value.Replace(',', ' ');
                            //reemplazar nuevas líneas incrustadas con espacios
                            value = value.Replace(Environment.NewLine, " ");

                            swOut.Write(value);
                        }
                    }
                    swOut.Close();
                }
                MessageBox.Show("Archivo exportado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            if (dgvmostrar.Rows.Count > 0)
            {
                try
                {
                    //Le paso los datos del datagrid a los textbox
                    validador = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                    dui = dgvmostrar.Rows[validador].Cells[1].Value.ToString();
                    txtnombre.Text = dgvmostrar.Rows[validador].Cells[0].Value.ToString();
                    txtdui.Text = dui;
                    txtnit.Text = dgvmostrar.Rows[validador].Cells[2].Value.ToString();
                    txtafp.Text = dgvmostrar.Rows[validador].Cells[3].Value.ToString();
                    txtseguro.Text = dgvmostrar.Rows[validador].Cells[4].Value.ToString();
                    txtdireccion.Text = dgvmostrar.Rows[validador].Cells[5].Value.ToString();
                    txttelefono.Text = dgvmostrar.Rows[validador].Cells[6].Value.ToString();
                    cbtipo.SelectedItem = dgvmostrar.Rows[validador].Cells[7].Value.ToString();
                    txtpago.Text = dgvmostrar.Rows[validador].Cells[8].Value.ToString();
                    fechanacimiento.SelectionStart = Convert.ToDateTime(dgvmostrar.Rows[validador].Cells[9].Value.ToString());
                    fechanacimiento.SelectionEnd = Convert.ToDateTime(dgvmostrar.Rows[validador].Cells[9].Value.ToString());
                    //Hago que estos datos no puedan ser modificados, porque son los identificadores unicos de cada trabajador
                    txtdui.ReadOnly = true;
                    txtafp.ReadOnly = true;
                    txtnit.ReadOnly = true;
                    txtseguro.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",

                Title = "Seleccionar Archivo"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgvmostrar.DataSource = ImportarDatos(openFileDialog.FileName);
                Trabajadores trabajador = new Trabajadores();
                //Lleno la lista con todos los datos que se agregaron del archivo
                for (int i = 0; i < dgvmostrar.Rows.Count - 1; i++)
                {
                    trabajador.Dui = dgvmostrar.Rows[i].Cells[1].Value.ToString();
                    trabajador.Nombre = dgvmostrar.Rows[i].Cells[0].Value.ToString();
                    trabajador.Nit = dgvmostrar.Rows[i].Cells[2].Value.ToString();
                    trabajador.Afp = dgvmostrar.Rows[i].Cells[3].Value.ToString();
                    trabajador.Seguro = dgvmostrar.Rows[i].Cells[4].Value.ToString();
                    trabajador.Direccion = dgvmostrar.Rows[i].Cells[5].Value.ToString();
                    trabajador.Telefono = dgvmostrar.Rows[i].Cells[6].Value.ToString();
                    trabajador.Tipo = dgvmostrar.Rows[i].Cells[7].Value.ToString();
                    trabajador.Pago = float.Parse(dgvmostrar.Rows[i].Cells[8].Value.ToString());
                    trabajador.Fecha = Convert.ToDateTime(dgvmostrar.Rows[i].Cells[9].Value.ToString());
                    lista.InsertarF(trabajador);
                }
                ActualizarDataGrid(lista);
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivo.TextLength != 0)
                {
                    ExportarDatos(dgvmostrar, "C:\\" + txtArchivo.Text + ".csv");
                    //Todos los archivos se exportan a la carpeta raiz C:\\ porque me daba problemas si lo mandaba a descargas
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el archivo por favor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

