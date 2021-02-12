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

namespace ExamenParcial1
{
    public partial class Inventario_form : BaseEstilo
    {
        private int edit_indice;
        private int id_inventario = 0;
        private int cantidad = 0;
        private string nombre_imagen = "";
        private string Chosen_File = "";
        private bool validado = false;
        private bool exito_imagen_subida = false;
        public Inventario_form()
        {
            InitializeComponent();
        }
        private void Inventario_form_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Inventario");
            cantidad = dgvmostrar.RowCount;
        }

        //Metodos
        private void ActualizarDataGrid()
        {
            dgvmostrar.DataSource = null;
            Conexion cn = new Conexion();
            cn.ConsultasLlenar(dgvmostrar, "Inventario");
        }
        private void reseteo()
        {
            txtdescripcion.Clear();
            txtexistencia.Clear();
            txtpcompra.Clear();
            txtpventa.Clear();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
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
        }

        private void dgvmostrar_Click(object sender, EventArgs e)
        {
            if (cantidad > 0)
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
            }  
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
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
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            openFD.Title = "Seleccione una imagen";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg";
            if (openFD.ShowDialog() == DialogResult.OK)
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
            }
            
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
    }
}