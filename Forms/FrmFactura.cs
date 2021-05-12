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
using SpreadsheetLight;

namespace SistemaInventario
{
    public partial class FrmFactura : Form
    {

        private int validador = -1;
        private int codigo = 0;
        int contador;
        ListaFactura lista = new ListaFactura();
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
        public FrmFactura()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ActualizarDataGrid(ListaFactura lista)
        {
            dgvmostrar.DataSource = null;
          
            dgvmostrar.DataSource = lista.Mostrar().ToList();
            dgvmostrar.ClearSelection();
            btnborrar.Enabled = false;
        }

        private void reseteo()
        {

            txtCantidad.Clear();
            txtCrepuesto.Clear();
            txtValormano.Clear();
            txtdescripcion.Clear();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                btnborrar.Enabled = false;
                btnEditar.Enabled = false;
                btnimportar.Enabled = false;
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
            if (txtCantidad.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtCantidad, "Por favor ingrese la cantidad de articulos");
            }
            if (txtCrepuesto.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtCrepuesto, "Por favor ingrese el costo del repuesto");
            }
            if (txtValormano.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtValormano, "Por favor ingrese el precio de la mano de obra");
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
            errorProvider1.SetError(txtCrepuesto, "");
            errorProvider1.SetError(txtValormano, "");
           
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtdescripcion, "");
      
        }

       

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
             
            contid.Text = Convert.ToString(Convert.ToInt32(contid.Text) +1);
            //validaciones
            BorrarMensaje();
            if (validaciones())
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades 
                try
                {
                    //Faltan validaciones
                    //Ahorita no las he activado porque sino hay que ingresar toooodos estos datos y es tedioso para hacer pruebas

                    //Creo un objeto del tipo trabajador y lleno los datos de este
                    
                    Factura factura = new Factura();
                    factura.Idfactua =Convert.ToInt32( contid.Text);
                    factura.Cantidad = int.Parse(txtCantidad.Text);
                    factura.Costo = Convert.ToInt32(txtCrepuesto.Text);
                    factura.Valor_mano_obra = float.Parse(txtValormano.Text);
                    factura.Costo_total = (factura.Costo+ factura.Valor_mano_obra)* factura.Cantidad;
                    factura.Descripcion_mano_obra = txtdescripcion.Text;

                    //Si el validador == -1 significa que un dato será INGRESADO
                
                        
                        //De ser así, ocupo el método InsertarF y le mando el objeto de tipo trabajador
                        lista.InsertarF(factura);
                        //Actualizo el datagrid mandandole la lista con el nuevo dato ingresado
                        ActualizarDataGrid(lista);
                
                    //Limpio pantalla
                    reseteo();

                        //Caso contrario, significa que el usuario está modificando un trabajador existente
                        //Hago que estos campos ahora sean modificables para cuando quiere ingresar un nuevo dato
                      

                        //Ocupo el método editar y le mando como parametro el DUI del trabajador a modificar y el objeto de tipo trabajador
                      //  lista.Editar(codigo, factura);
                        //Actualizo el datagrid
                       
                        //Hago que el validador sea nuevamente -1 y el dui le doy un valor nulo
                       
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            /* }
             else
             {
                 MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

             }*/
        }




        private void picBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDatosAlumnos_SelectionChanged(object sender, EventArgs e)
        {
           
         
        }

        private void txtFoto_Click(object sender, EventArgs e)
        {
            /*openFileFoto.InitialDirectory = "C:\\";
            openFileFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            try
            {
                if (openFileFoto.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileFoto.FileName;
                    txtFoto.Text = sourceFile;

                    System.IO.FileStream fs = new System.IO.FileStream(sourceFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    pbFotoAlumno.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    btnagregar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            // NO AGREGAMOS IMAGEN 

            /*

            openFD.Title = "Seleccione una imagen";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";

          

            try
            {
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFD.FileName;
                    btnagregar.Text = sourceFile;

                    //pbFotoProducto.Image = Image.FromFile(sourceFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */

        }

        //REVISAR SI SE AGREGARA
        private void btnEliminarA_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }

        

        private void dgvDatosAlumnos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvmostrar.Rows.Count > 0)
            {
                try
                {
                    btnagregar.Enabled = false;
                    btnEditar.Enabled = true;
                    string Chosen_file2 = "";
                    //Le paso los datos del datagrid a los textbox
                    validador = dgvmostrar.Rows.IndexOf(dgvmostrar.SelectedRows[0]);
                    contid.Text = dgvmostrar.Rows[validador].Cells[0].Value.ToString();
                    txtCantidad.Text = dgvmostrar.Rows[validador].Cells[1].Value.ToString();
                    txtCrepuesto.Text = dgvmostrar.Rows[validador].Cells[2].Value.ToString();
                    txtValormano.Text = dgvmostrar.Rows[validador].Cells[4].Value.ToString();
                    
                    txtdescripcion.Text = dgvmostrar.Rows[validador].Cells[3].Value.ToString();
                    
                   
                    
                    
                    //lblruta.Text = Chosen_file2;

                 


                    //Hago que estos datos no puedan ser modificados, porque son los identificadores unicos de cada trabajador
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        //REVISAR SI SE AGREGARA
        private void btnEditarA_Click(object sender, EventArgs e)
        {
/*  
            //validaciones
            BorrarMensaje();
            if (validaciones())
            {
            if (validador != -1)
                {
                    try
                    {

                   
                        //Esto lo tenía para ver que el dato correcto se estaba borrando  MessageBox.Show(dui);

                        //Creo un nuevo objeto del tipo lista
                        ListaInventario lista2 = new ListaInventario();

                        //Le paso todos los valores que no sean los que se quieren borrar de la lista global
                        foreach (Factura factura in lista.EnCola(codigo))
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
                        txtCantidad.ReadOnly = false;
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
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        //private void btnexportar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtArchivo.TextLength != 0)
        //        {
        //            ExportarDatos(dgvmostrar, "C:\\" + txtArchivo.Text + ".csv");
        //            //Todos los archivos se exportan a la carpeta raiz C:\\ porque me daba problemas si lo mandaba a descargas
        //        }
        //        else
        //        {
        //            MessageBox.Show("Ingrese un nombre para el archivo por favor");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
                errorProvider1.SetError(txtCantidad, "En este campo sólo se permiten numeros");
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
                errorProvider1.SetError(txtCantidad, "En este campo sólo se permiten numeros");
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
                errorProvider1.SetError(txtCantidad, "En este campo sólo se permiten numeros");
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
                errorProvider1.SetError(txtCantidad, "En este campo sólo se permiten numeros");
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtdescripcion.TextLength > 0)
            {
                btnagregar.Enabled = true;
            }
            else
            {
                btnagregar.Enabled = false;
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
        private void Exportar(DataGridView datalistado, string outputFile)
        {
            if (datalistado.RowCount > 0 && File.Exists(outputFile) != true)
            {
                try
                {
                    SLDocument sl = new SLDocument();

                    int iC = 1;
                    SLStyle style = new SLStyle();
                    style.Font.Bold = true;

                    foreach (DataGridViewColumn column in dgvmostrar.Columns)
                    {
                        sl.SetCellValue(1, iC, column.HeaderText.ToString());
                        sl.SetCellStyle(1, iC, style);
                        iC++;
                    }

                    int iR = 2;
                    foreach (DataGridViewRow row in dgvmostrar.Rows)
                    {
                        sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        sl.SetCellValue(iR, 3, double.Parse(row.Cells[2].Value.ToString()));
                        sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        sl.SetCellValue(iR, 5, double.Parse(row.Cells[4].Value.ToString()));
                        sl.SetCellValue(iR, 6, double.Parse(row.Cells[5].Value.ToString()));
                        
                        MessageBox.Show(row.Cells[0].Value.ToString());
                      
                        iR++;
                    }
                    sl.SaveAs(outputFile);
                    MessageBox.Show("Archivo exportado correctamente", "¡Enhorabuea!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al exportar " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay Registros a Exportar o el nombre del documento ya existe", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArchivo.TextLength != 0)
                {
                    Exportar(dgvmostrar, "D:\\" + txtArchivo.Text + ".xlsx");
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el archivo por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validaciones())
            {
                if (validador != -1)
                {
                    try
                    {

                        Factura factura = new Factura();
                        codigo = Convert.ToInt32(contid.Text);
                        factura.Idfactua = Convert.ToInt32(contid.Text);
                        factura.Cantidad = int.Parse(txtCantidad.Text);
                        factura.Costo = Convert.ToInt32(txtCrepuesto.Text);
                        factura.Valor_mano_obra = float.Parse(txtValormano.Text);
                        factura.Costo_total = (factura.Costo + factura.Valor_mano_obra) * factura.Cantidad;
                        factura.Descripcion_mano_obra = txtdescripcion.Text;
                        //Esto lo tenía para ver que el dato correcto se estaba borrando  MessageBox.Show(dui);

                        //Creo un nuevo objeto del tipo lista
                        lista.Editar(codigo, factura);
                        //Reinicio los validadores
                        ActualizarDataGrid(lista);
                        reseteo();
                        //Hago que el validador sea nuevamente -1 y el dui le doy un valor nulo
                        validador = -1;
                        codigo = 0;
                        btnagregar.Enabled = true;
                        btnEditar.Enabled = false;
                    


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
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvmostrar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvmostrar.ClearSelection();
        }

        private void dgvmostrar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmostrar.SelectedRows.Count > 0)
            {
                try
                {
                    reseteo();
                    btnborrar.Enabled = true;
                    btnagregar.Enabled = false;
                    btnEditar.Enabled = false;
                    codigo = int.Parse(dgvmostrar.CurrentRow.Cells["Idfactura"].Value.ToString());

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dgvmostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
