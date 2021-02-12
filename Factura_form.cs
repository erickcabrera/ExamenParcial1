using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamenParcial1
{
    public partial class Factura_form : BaseEstilo
    {
        private int opcion = -1;
        private string nombre;
        private string identificador;
        List<Factura> facturas = new List<Factura>();
        public Factura_form()
        {
            InitializeComponent();
        }

        private void actualizarDgv(List<Factura> facturas)
        {
            dgv.DataSource = null;
            dgv.DataSource = facturas;
        }

        //Metodos
        private void agregarImagen()
        {
            ImageList imagenes = new ImageList();
            imagenes.ImageSize = new Size(50, 50);

            //Directorio
            Conexion cn = new Conexion();
            List<string> paths = new List<string>();
            paths = cn.ConsultasLlenarImgList();
            string[] nombre_imagen = new string[paths.Count];
            int f = 0;
            try
            {
                foreach (string path in paths)
                {
                    imagenes.Images.Add(Image.FromFile(path));
                    nombre_imagen[f] = Path.GetFileNameWithoutExtension(path);
                    //Hacer que el Indice sea el ID del repuesto
                    lv1.Items.Add(nombre_imagen[f], f);
                    f++;
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }

            //Uniendo imagenes al listview
            lv1.SmallImageList = imagenes;
        }

        //Funcionalidades
        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            bool existe = false;
            int pos = 0;
            if (opcion == 1)
            {
                for (int i = 0; i < (dgv.Rows.Count); i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.Equals(nombre))
                    {
                        existe = true;
                        pos = i;
                    }
                }

                if (existe == true)
                {
                    int cantidad = int.Parse(dgv.Rows[pos].Cells[1].Value.ToString());
                    dgv.Rows[pos].Cells[1].Value = (cantidad + 1).ToString();
                    dgv.Rows[pos].Cells[3].Value = (int.Parse(dgv.Rows[pos].Cells[1].Value.ToString()) * float.Parse(dgv.Rows[pos].Cells[2].Value.ToString()));
                    opcion = -1;
                    nombre = "";
                    int cantidadp = 0;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        cantidadp = cantidadp + Convert.ToInt32(dgv.Rows[i].Cells[1].Value.ToString());
                    }
                    txtcantidad.Text = cantidadp.ToString();
                    float costo = 0;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        costo = costo + float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    }
                    txtcosto.Text = Convert.ToString(costo);
                    if (txtcosto.TextLength > 0)
                    {
                        float mano_obra = 0;
                        if (txtmanoobra.TextLength > 0)
                        {
                            mano_obra = float.Parse(txtmanoobra.Text);
                            txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                        }
                        else
                        {
                            txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                        }
                    }
                }
                else
                {
                    Conexion cn = new Conexion();
                    Factura factura = new Factura();
                    factura.Nombre = nombre;
                    factura.Cantidad = 1;
                    factura.Id_repuesto = cn.ConsultasObtenerIdRepuesto(nombre);
                    int id = factura.Id_repuesto;
                    Conexion cn2 = new Conexion();
                    factura.Precio = cn2.ConsultasObtenerPrecio(id);
                    factura.Costo = factura.Precio * factura.Cantidad;
                    facturas.Add(factura);
                    actualizarDgv(facturas);
                    opcion = -1;
                    nombre = "";
                    int cantidadp = 0;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        cantidadp = cantidadp + Convert.ToInt32(dgv.Rows[i].Cells[1].Value.ToString());
                    }
                    txtcantidad.Text = cantidadp.ToString();
                    float costo = 0;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        costo = costo + float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    }
                    txtcosto.Text = Convert.ToString(costo);
                    if (txtcosto.TextLength > 0)
                    {
                        float mano_obra = 0;
                        if (txtmanoobra.TextLength > 0)
                        {
                            mano_obra = float.Parse(txtmanoobra.Text);
                            txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                        }
                        else
                        {
                            txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una opción primero");
            }
        }
        private void btnremover_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int pos = 0;
            if (opcion == 1)
            {
                for (int i = 0; i < (dgv.Rows.Count); i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.Equals(nombre))
                    {
                        existe = true;
                        pos = i;
                    }
                }
                if (existe)
                {
                    int cantidad = int.Parse(dgv.Rows[pos].Cells[1].Value.ToString());
                    if (cantidad > 1)
                    {
                        dgv.Rows[pos].Cells[1].Value = (cantidad - 1).ToString();
                        dgv.Rows[pos].Cells[3].Value = (int.Parse(dgv.Rows[pos].Cells[1].Value.ToString()) * float.Parse(dgv.Rows[pos].Cells[2].Value.ToString()));
                        opcion = -1;
                        nombre = "";
                        int cantidadp = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            cantidadp = cantidadp + Convert.ToInt32(dgv.Rows[i].Cells[1].Value.ToString());
                        }
                        txtcantidad.Text = cantidadp.ToString();
                        float costo = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            costo = costo + float.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                        }
                        txtcosto.Text = Convert.ToString(costo);
                        if (txtcosto.TextLength > 0)
                        {
                            float mano_obra = 0;
                            if (txtmanoobra.TextLength > 0)
                            {
                                mano_obra = float.Parse(txtmanoobra.Text);
                                txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                            }
                            else
                            {
                                txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                            }
                        }
                    }
                    else
                    {
                        facturas.RemoveAt(pos);
                        actualizarDgv(facturas);
                        opcion = -1;
                        nombre = "";
                        int cantidadp = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            cantidadp = cantidadp + Convert.ToInt32(dgv.Rows[i].Cells[1].Value.ToString());
                        }
                        txtcantidad.Text = cantidadp.ToString();
                        float costo = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            costo = costo + float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                        }
                        txtcosto.Text = Convert.ToString(costo);
                        if (txtcosto.TextLength > 0)
                        {
                            float mano_obra = 0;
                            if (txtmanoobra.TextLength > 0)
                            {
                                mano_obra = float.Parse(txtmanoobra.Text);
                                txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                            }
                            else
                            {
                                txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este artículo aún no ha sido agregado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opción primero");
            }
        }
        private void Factura_form_Load(object sender, EventArgs e)
        {
            //Cargo el list view
            lv1.View = View.Details;
            //Aggregando columnas 
            lv1.Columns.Add("Imagen", 250);
            agregarImagen();
        }

        //Eventos
        private void lv1_Click(object sender, EventArgs e)
        {
            opcion = 1;
            nombre = lv1.SelectedItems[0].Text;
        }
        private void txtmanoobra_TextChanged(object sender, EventArgs e)
        {
            if (txtcosto.TextLength > 0)
            {
                float mano_obra = 0;
                if (txtmanoobra.TextLength > 0)
                {
                    mano_obra = float.Parse(txtmanoobra.Text);
                    txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                }
                else
                {
                    txttotal.Text = Convert.ToString(float.Parse(txtcosto.Text) + mano_obra);
                } 
            }
        }

        //Captura de datos
        private void btningresar_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                Conexion cn = new Conexion();
                Factura2 factura = new Factura2();
                factura.Id_repuestos = "";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (i == (dgv.Rows.Count - 1)) {
                        factura.Id_repuestos = factura.Id_repuestos + dgv.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        factura.Id_repuestos = factura.Id_repuestos + dgv.Rows[i].Cells[4].Value.ToString() + ", ";
                    }    
                }
                factura.Repuestos = "";
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (i == (dgv.Rows.Count - 1))
                    {
                        factura.Repuestos = factura.Repuestos + dgv.Rows[i].Cells[0].Value.ToString();
                    }
                    else
                    {
                        factura.Repuestos = factura.Repuestos + dgv.Rows[i].Cells[0].Value.ToString() + ", ";
                    }
                }
                if (txtmanoobra.TextLength>0)
                {
                    factura.Valor_mano_obra = float.Parse(txtmanoobra.Text);
                }
                else
                {
                    factura.Valor_mano_obra = 0;
                }
                factura.Cantidad = int.Parse(txtcantidad.Text);
                factura.Costo = float.Parse(txtcosto.Text);
                factura.Costo_total = float.Parse(txttotal.Text);
                factura.Descripcion_mano_obra = txtdescripcion.Text;
                factura.Id_trabajador = 2;
                //Arreglar ID trabajador
                if (cn.ConsultasInsertarFactura(factura) == 1) {
                    MessageBox.Show("Factura agregada correctamente");
                }
                else
                {
                    MessageBox.Show(factura.Id_repuestos.ToString());

                }
            }
        }
        //Abriendo el formulario que muestra las facturas
        private void btnverfacturas_Click(object sender, EventArgs e)
        {
            Factura_mostrar form = new Factura_mostrar();
            form.Show();
            this.Hide();
        }
    }
}