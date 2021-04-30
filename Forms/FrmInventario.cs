using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Security.Permissions;
using System.Security;
using System.Data.OleDb;

namespace SistemaInventario
{
    public partial class FrmInventario : Form
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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );
        public FrmInventario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ActualizarDataGrid(ListaInventario lista)
        {
            dgvmostrar.DataSource = null;
            dgvmostrar.DataSource = lista.Mostrar().ToList();
            dgvmostrar.ClearSelection();
            btnborrar.Enabled = false;
        }

        private void reseteo()
        {
            txtdescripcion.Clear();
            txtexistencia.Clear();
            txtpcompra.Clear();
            txtpventa.Clear();
            txtCodigo.Clear();
            pbFotoProducto.Image = Image.FromFile("..\\..\\Imagenes\\subir.png");
            btncargar.Text = "Seleccionar foto...";
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                btnborrar.Enabled = false;
                btnimportar.Enabled = false;
                btnEditar.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validar que la fecha de nacimiento no sea mayor a la fecha del sistema

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
        

        private bool validaciones()
        {
            bool validacion = true;
            if (txtCodigo.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtCodigo, "Por favor ingrese el codigo del articulo");
            }
            if (txtexistencia.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtexistencia, "Por favor ingrese la cantidad de existencia del articulo");
            }
            if (txtpcompra.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtpcompra, "Por favor ingrese el precio de compra del articulo");
            }
            if (txtpventa.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtpventa, "Por favor ingrese el precio de venta del articulo");
            }
            if (txtdescripcion.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtdescripcion, "Por favor ingrese una descripción del articulo");
            }
           
            return validacion;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtdescripcion, "");
            errorProvider1.SetError(txtexistencia, "");
            errorProvider1.SetError(txtpcompra, "");
            errorProvider1.SetError(txtpventa, "");
            errorProvider1.SetError(txtCodigo, "");
        }
        
        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validaciones())
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades 
                if (btncargar.Text == "Seleccionar foto...")
                {
                    MessageBox.Show("Debe seleccionar una foto", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Queue<Inventario> cola = new Queue<Inventario>();
                    cola = lista.Mostrar();
                    bool idCodigo = false;

                    foreach (var item in cola)
                    {
                        if (item.Codigo == int.Parse(txtCodigo.Text))
                        {
                            idCodigo = true;
                        }
                    }

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
                        inventario.Ruta_imagen = "..\\..\\Imagenes\\" + (txtCodigo.Text + "-" + txtdescripcion.Text + ".jpg");
                        
                        //Si el validador == -1 significa que un dato será INGRESADO
                        /*if (validador == -1)
                        {*/
                        if (idCodigo == false)
                        {
                            //De ser así, ocupo el método InsertarF y le mando el objeto de tipo trabajador
                            lista.InsertarF(inventario);

                            //COPIAMOS IMAGEN
                            String sourceFile = btncargar.Text;
                            String destinationFile = inventario.Ruta_imagen;

                            try
                            {

                                if (!File.Exists(inventario.Ruta_imagen))
                                {
                                    File.Copy(sourceFile, destinationFile);
                                }
                                else
                                {
                                    MessageBox.Show("Imagen ya existe");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex.Message);
                            }

                            //Actualizo el datagrid mandandole la lista con el nuevo dato ingresado
                            ActualizarDataGrid(lista);

                            //Limpio pantalla
                            reseteo();

                        }
                        else
                        {
                            MessageBox.Show("El codigo ingresado ya existe", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        
        private void picBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDatosAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmostrar.SelectedRows.Count > 0)
            {
                try
                {
                    reseteo();
                    btnborrar.Enabled = true;
                    btnagregar.Enabled = true;
                    btnEditar.Enabled = false;
                    codigo = int.Parse(dgvmostrar.CurrentRow.Cells["Codigo"].Value.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtFoto_Click(object sender, EventArgs e)
        {
            openFD.Title = "Seleccione una imagen";
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";

            try
            {
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFD.FileName;
                    btncargar.Text = sourceFile;

                    FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                    pbFotoProducto.Image = Image.FromStream(fs);
                    fs.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarA_Click(object sender, EventArgs e)
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

        

        private void dgvDatosAlumnos_DoubleClick(object sender, EventArgs e)
        {
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

                    
                    System.IO.FileStream fs = new System.IO.FileStream(Chosen_file2, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    pbFotoProducto.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();

                    lblruta.Text = Chosen_file2;

                    txtCodigo.Text = Convert.ToString(codigo);


                    txtpcompra.Text = dgvmostrar.Rows[validador].Cells[3].Value.ToString();
                    txtpventa.Text = dgvmostrar.Rows[validador].Cells[4].Value.ToString();
                    txtexistencia.Text = dgvmostrar.Rows[validador].Cells[5].Value.ToString();

                    btnEditar.Enabled = true;
                    btnborrar.Enabled = false;
                    btnagregar.Enabled = false;

                    //Hago que estos datos no puedan ser modificados, porque son los identificadores unicos de cada trabajador
                    txtCodigo.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     

        private void btnexportar_Click(object sender, EventArgs e)
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                /*MessageBox.Show("Solo se admiten numeros", "validación de numeros",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                errorProvider1.SetError(txtCodigo, "En este campo sólo se permiten numeros");
            }
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
                /*MessageBox.Show("Solo se admiten numeros", "validación de numeros",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                errorProvider1.SetError(txtexistencia, "En este campo sólo se permiten numeros");
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
                /*MessageBox.Show("Solo se admiten numeros", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                errorProvider1.SetError(txtpcompra, "En este campo sólo se permiten numeros");
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
                /*MessageBox.Show("Solo se admiten numeros", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                errorProvider1.SetError(txtpventa, "En este campo sólo se permiten numeros");
            }
        }




        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtdescripcion.TextLength > 0)
            {
                btncargar.Enabled = true;
            }
            else
            {
                btncargar.Enabled = false;
            }


            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtdescripcion, "En este campo sólo se permiten letras");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (dgvmostrar.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el articulo con codigo " + codigo + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
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


                        //Borramos imagen
                        try
                        {
                            if (System.IO.File.Exists(dgvmostrar.CurrentRow.Cells["Ruta_imagen"].Value.ToString()))
                            {
                                System.IO.File.Delete(dgvmostrar.CurrentRow.Cells["Ruta_imagen"].Value.ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al borrar imagen " + ex.Message);
                        }


                        //Actualizo el datagrid
                        ActualizarDataGrid(lista);
                        //Reinicio los validadores
                        validador = -1;
                        reseteo();
                        txtCodigo.ReadOnly = false;
                        codigo = 0;
                        btnagregar.Enabled = true;
                        btnEditar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnborrar.Enabled = false;
                    dgvmostrar.ClearSelection();
                    reseteo();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validaciones())
            {
                try
                {
                    Inventario inventario = new Inventario();
                    inventario.Codigo = int.Parse(txtCodigo.Text);
                    inventario.Descripcion = txtdescripcion.Text;
                    inventario.Existencia = Convert.ToInt32(txtexistencia.Text);
                    inventario.Precio_compra = float.Parse(txtpcompra.Text);
                    inventario.Precio_venta = float.Parse(txtpventa.Text);
                    inventario.Ruta_imagen = "..\\..\\Imagenes\\" + (txtCodigo.Text + "-" + txtdescripcion.Text + ".jpg");

                    
                    if (btncargar.Text != "Seleccionar foto...")
                    {

                        try
                        {
                            if (File.Exists(lblruta.Text))
                            {
                                File.Delete(lblruta.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al borrar imagen " + ex.Message);
                        }
                        
                        String sourceFile = btncargar.Text;
                        String destinationFile = inventario.Ruta_imagen;

                        try
                        {
                            if (!File.Exists(inventario.Ruta_imagen))
                            {
                                File.Copy(sourceFile, destinationFile);
                            }
                            else
                            {
                                MessageBox.Show("Imagen ya existe");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        inventario.Ruta_imagen = lblruta.Text;
                    }

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
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar registro " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
