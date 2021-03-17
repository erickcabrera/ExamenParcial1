using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaInventario
{
    public partial class FormInventario : Form
    {
        private int validador = -1;
        private int codigo = 0;
        ListaInventario lista = new ListaInventario();
        private int edit_indice;
        private int id_inventario = 0;
        private int cantidad = 0;
        private string nombre_imagen = "";
        private string Chosen_File = "";
        private bool validado = false;
        private bool exito_imagen_subida = false;
        public FormInventario()
        {
            InitializeComponent();
        }
        
        private void Inventario_form_Load(object sender, EventArgs e)
        {
            /*
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Inventario");
            cantidad = dgvmostrar.RowCount;
            */
        }

        //El metodo tiene como parametro un objeto de tipo lista. El cual luego ocupo el método Mostrar la Lista
        //Esto me devuelve una cola y la uso como DataSource
        private void ActualizarDataGrid(ListaInventario lista)
        {
            dgvmostrar.DataSource = null;
            dgvmostrar.DataSource = lista.Mostrar().ToList();
        }
      
        private void reseteo()
        {
            txtdescripcion.Clear();
            txtexistencia.Clear();
            txtpcompra.Clear();
            txtpventa.Clear();
            txtCodigo.Clear();
            pictureBox1.Image = Image.FromFile("..\\..\\Imagenes\\subir.png");
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            /*
            if (validaciones())
            {
                errorProvider1.Clear();

                Conexion cn = new Conexion();
                Inventario inventario = new Inventario();
                inventario.Descripcion = txtdescripcion.Text;
                inventario.Existencia = Convert.ToInt32(txtexistencia.Text);
                inventario.Precio_compra = float.Parse(txtpcompra.Text);
                inventario.Precio_venta = float.Parse(txtpventa.Text);
                inventario.Ruta_imagen = "..\\..\\Imagenes\\" + (txtdescripcion.Text + ".jpg");
                //Agregando imagen a directorio
                File.Copy(Chosen_File, "..\\..\\Imagenes\\" + Path.GetFileName(txtdescripcion.Text + ".jpg"));
                if (id_inventario != 0)
                {

                    if (cn.ConsultasActualizarInventario(inventario, id_inventario) == 0)
                    {
                        MessageBox.Show("No se pudo actualizar en la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Datos actualizados");
                        ActualizarDataGrid();
                        reseteo();
                        id_inventario = 0;
                        pictureBox1.Image = Image.FromFile("..\\..\\Imagenes\\subir.png");
                    }
                }
                else
                {
                    if (cn.ConsultasInsertarInventario(inventario) == 0)
                    {
                        MessageBox.Show("No se pudo ingresar a la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        ActualizarDataGrid();
                        reseteo();
                        pictureBox1.Image = Image.FromFile("..\\..\\Imagenes\\subir.png");
                    }
                }
            }
            */

            try
            {
                //Faltan validaciones
                //Ahorita no las he activado porque sino hay que ingresar toooodos estos datos y es tedioso para hacer pruebas

                //Creo un objeto del tipo trabajador y lleno los datos de este
                Inventario inventario = new Inventario();
                inventario.Codigo = int.Parse(txtCodigo.Text);
                inventario.Descripcion = txtdescripcion.Text;
                inventario.Existencia = Convert.ToInt32(txtexistencia.Text);
                inventario.Precio_compra = float.Parse(txtpcompra.Text);
                inventario.Precio_venta = float.Parse(txtpventa.Text);
                inventario.Ruta_imagen = "..\\..\\Imagenes\\" + (txtdescripcion.Text + ".jpg");
                //Agregando imagen a directorio
                //File.Copy(Chosen_File, "..\\..\\Imagenes\\" + Path.GetFileName(txtdescripcion.Text + ".jpg"));


                //pbImagen.Image = Image.FromFile(imagen);

                String sourceFile = lblruta.Text;
                String destinationFile = inventario.Ruta_imagen;

                try
                {
                    System.IO.File.Copy(sourceFile, destinationFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                //Si el validador == -1 significa que un dato será INGRESADO
                if (validador == -1)
                {
                    //De ser así, ocupo el método InsertarF y le mando el objeto de tipo trabajador
                    lista.InsertarF(inventario);
                    //Actualizo el datagrid mandandole la lista con el nuevo dato ingresado
                    ActualizarDataGrid(lista);
                    //Limpio pantalla
                    reseteo();
                }
                else
                {
                    //Caso contrario, significa que el usuario está modificando un trabajador existente
                    //Hago que estos campos ahora sean modificables para cuando quiere ingresar un nuevo dato
                    txtCodigo.ReadOnly = false;
                    txtdescripcion.ReadOnly = false;
                    txtexistencia.ReadOnly = false;
                    txtpcompra.ReadOnly = false;
                    txtpventa.ReadOnly = false;

                    //Ocupo el método editar y le mando como parametro el DUI del trabajador a modificar y el objeto de tipo trabajador
                    lista.Editar(codigo, inventario);
                    //Actualizo el datagrid
                    ActualizarDataGrid(lista);
                    reseteo();
                    //Hago que el validador sea nuevamente -1 y el dui le doy un valor nulo
                    validador = -1;
                    codigo = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            /*if (cantidad > 0)
            {
                string Chosen_file2 = "";
                edit_indice = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                id_inventario = Convert.ToInt32(dgvmostrar.Rows[edit_indice].Cells[0].Value);
                txtexistencia.Text = dgvmostrar.Rows[edit_indice].Cells[1].Value.ToString();
                txtdescripcion.Text = dgvmostrar.Rows[edit_indice].Cells[2].Value.ToString();
                txtpcompra.Text = dgvmostrar.Rows[edit_indice].Cells[3].Value.ToString();
                txtpventa.Text = dgvmostrar.Rows[edit_indice].Cells[4].Value.ToString();
                nombre_imagen = Path.GetFileName(dgvmostrar.Rows[edit_indice].Cells[5].Value.ToString());
                Chosen_file2 = dgvmostrar.Rows[edit_indice].Cells[5].Value.ToString();
                pictureBox1.Image = Image.FromFile(Chosen_file2);
            }  */

            if (dgvmostrar.Rows.Count > 0)
            {
                try
                {
                    string Chosen_file2 = "";
                    //Le paso los datos del datagrid a los textbox
                    validador = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);

                    codigo = Convert.ToInt32(dgvmostrar.Rows[validador].Cells[0].Value.ToString());
                    txtdescripcion.Text = dgvmostrar.Rows[validador].Cells[1].Value.ToString();

                    nombre_imagen = Path.GetFileName(dgvmostrar.Rows[validador].Cells[2].Value.ToString());
                    Chosen_file2 = dgvmostrar.Rows[validador].Cells[2].Value.ToString();
                    pictureBox1.Image = Image.FromFile(Chosen_file2);
                    lblruta.Text = Chosen_file2;

                    txtCodigo.Text = Convert.ToString(codigo);


                    txtpcompra.Text = dgvmostrar.Rows[validador].Cells[3].Value.ToString();
                    txtpventa.Text = dgvmostrar.Rows[validador].Cells[4].Value.ToString();
                    txtexistencia.Text = dgvmostrar.Rows[validador].Cells[5].Value.ToString();


                    //Hago que estos datos no puedan ser modificados, porque son los identificadores unicos de cada trabajador
                    txtCodigo.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            /*
            if (validaciones())
            {
                errorProvider1.Clear();
                if (id_inventario != 0) //verifica si hay un índice seleccionado
                {
                    Conexion cn = new Conexion();
                    if (cn.ConsultasBorrar(id_inventario, "Inventario") == 1)
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
            */

            //Faltan validaciones

            //Pruebo si ha sido seleccionado un dato del datagrid
            if (validador != -1)
            {
                try
                {
                    //Esto lo tenía para ver que el dato correcto se estaba borrando  MessageBox.Show(dui);

                    //Creo un nuevo objeto del tipo lista
                    ListaInventario lista2 = new ListaInventario();

                    //Le paso todos los valores que no sean los que se quieren borrar de la lista global
                    foreach (Inventario inventario in lista.EnCola(codigo))
                    {
                        lista2.InsertarF(inventario);
                    }
                    //Hago que la lista global sea igual a la nueva lista, es decir, que tenga los valores nuevos excepto el borrado
                    lista = lista2;
                    //Actualizo el datagrid
                    ActualizarDataGrid(lista);
                    //Reinicio los validadores
                    validador = -1;
                    reseteo();
                    txtCodigo.ReadOnly = false;
                    codigo = 0;
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

        private void btncargar_Click(object sender, EventArgs e)
        {
            openFD.Title = "Seleccione una imagen";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";

            try
            {
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFD.FileName;
                    lblruta.Text = sourceFile;

                    pictureBox1.Image = Image.FromFile(sourceFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            /*if (openFD.ShowDialog() == DialogResult.OK)
            {
                string[] articulo = new string[dgvmostrar.Rows.Count];
                for (int i = 0; i < (dgvmostrar.Rows.Count-1); i++)
                {
                    articulo[i] = dgvmostrar.Rows[i].Cells[2].Value.ToString();
                }
                for (int i = 0; i < (dgvmostrar.Rows.Count-1); i++)
                {
                    if (txtdescripcion.Text == articulo[i])
                    {
                        MessageBox.Show("El nombre del articulo ya existe, por favor elija otro");
                        txtdescripcion.Clear();
                        txtdescripcion.Focus();
                        btnagregar.Enabled = false;

                    }
                }       
                if (validado)
                {
                    MessageBox.Show("Imagen agregada correctamente");
                    Chosen_File = openFD.FileName;
                    pictureBox1.Image = Image.FromFile(openFD.FileName);
                    nombre_imagen = Path.GetFileName(openFD.FileName);
                    exito_imagen_subida = true;
                    txtdescripcion.ReadOnly = true;
                } 
            }
            else
            {
                MessageBox.Show("Operacion cancelada");
            }*/


        }
        //Validaciones
        private bool validaciones()
        {
            bool validacion = true;
            if (txtexistencia.TextLength == 0)
            {
                validacion = false;
                errorProvider1.SetError(txtexistencia, "Por favor ingrese la cantidad de existencia del articulo");
            }
            if (txtpcompra.TextLength == 0)
            {
                validacion = false;
                errorProvider1.SetError(txtpcompra, "Por favor ingrese el precio de compra del articulo");
            }
            if (txtpventa.TextLength == 0)
            {
                validacion = false;
                errorProvider1.SetError(txtpventa, "Por favor ingrese el precio de venta del articulo");
            }
            if (txtdescripcion.TextLength == 0)
            {
                validacion = false;
                errorProvider1.SetError(txtdescripcion, "Por favor ingrese el nombre del articulo");
            }
            if (validacionPrecios() == false)
            {
                validacion = false;
                errorProvider1.SetError(txtpventa, "El precio de venta debe ser mayor al precio de compra");
            }
            if (validado == false)
            {
                validacion = false;
                errorProvider1.SetError(txtdescripcion, "El nombre del articulo ya existe. Por favor elija otro");
            }
            if (exito_imagen_subida == false)
            {
                validacion = false;
                errorProvider1.SetError(btncargar, "Por favor suba una imagen");
            }
            return validacion;
        }

        private bool validacionPrecios()
        {
            bool validacion = true;
            if (float.Parse(txtpcompra.Text) >= float.Parse(txtpventa.Text))
            {
                validacion = false;
                txtpventa.Clear();
                txtpventa.Focus();
            }
            return validacion;
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpcompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripcion.TextLength > 0)
            {
                btncargar.Enabled = true;
            }
            else
            {
                btncargar.Enabled = false;
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
                Inventario inventario = new Inventario();
                //Lleno la lista con todos los datos que se agregaron del archivo
                for (int i = 0; i < dgvmostrar.Rows.Count - 1; i++)
                {
                    inventario.Codigo = Convert.ToInt32(dgvmostrar.Rows[validador].Cells[0].Value.ToString());
                    inventario.Descripcion = dgvmostrar.Rows[i].Cells[1].Value.ToString();
                    inventario.Ruta_imagen = dgvmostrar.Rows[i].Cells[2].Value.ToString();
                    inventario.Precio_compra = Convert.ToInt32(dgvmostrar.Rows[validador].Cells[3].Value.ToString());
                    inventario.Precio_venta = Convert.ToInt32(dgvmostrar.Rows[validador].Cells[4].Value.ToString());
                    inventario.Existencia = Convert.ToInt32(dgvmostrar.Rows[validador].Cells[5].Value.ToString());

                    lista.InsertarF(inventario);
                }
                ActualizarDataGrid(lista);
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


    }
}