using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace ExamenParcial1
{
    class Conexion
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public SqlDataAdapter da;
        public DataTable dt;
        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=HAISE-PC\\SQLEXPRESS;Initial Catalog=POO;Integrated Security=True");
                cn.Open();
                //label.Text = "Conexion establecida";
            }
            catch (Exception ex)
            {
                String Excepcion = "Conexion fallida: " + Convert.ToString(ex);

            }

        }
        //Metodo para loguerarse
        public int Consultas(string usuario, string pass)
        {
            int contador = 0;
            try
            {
                //Agregar encriptacion de password
                cmd = new SqlCommand("SELECT usuario, password FROM Trabajador WHERE usuario = '" + usuario + "' AND password = '" + pass + "'", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    contador++;
                }
            } catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);

            }
            return contador;
        }
        public int ConsultasInsertar(Trabajadores trabajador)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("INSERT INTO Trabajador (nombre, fecha_nacimiento, dui, nit, afp, num_seguro, direccion, pago_dia, num_telefono,tipo) VALUES ('" + trabajador.Nombre + "', '" + trabajador.Fecha + "', '" + trabajador.Dui + "','" + trabajador.Nit + "', '" + trabajador.Afp + "', '" + trabajador.Seguro + "', '" + trabajador.Direccion + "', " + trabajador.Pago + ", '" + trabajador.Telefono + "', '" + trabajador.Tipo + "')", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }
        public int ConsultasInsertarInventario(Inventario inventario)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("INSERT INTO Inventario (existencia, descripcion, precio_compra, precio_venta, ruta_imagen) VALUES (" + inventario.Existencia + ", '" + inventario.Descripcion + "', " + inventario.Precio_compra + ", " + inventario.Precio_venta + ", '" + inventario.Ruta_imagen + "')", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }
        public int ConsultasInsertarPlanilla(Planilla planilla)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("INSERT INTO Planilla VALUES(" + planilla.Id_trabajador + ", " + planilla.Dias_trabajados + ", '" + planilla.Fecha_inicio + "', '" + planilla.Fecha_final + "', " + planilla.Pago + ")", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }
        public int ConsultasInsertarFactura(Factura2 factura)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("INSERT INTO Factura (id_repuestos, repuestos, valor_mano_obra, costo_repuesto, costo_total, id_trabajador, cantidad_repuestos, descripcion_mano_obra) VALUES('" + factura.Id_repuestos + "', '" + factura.Repuestos + "', " + factura.Valor_mano_obra + ", " + factura.Costo + ", " + factura.Costo_total + ", " + factura.Id_trabajador + ", " + factura.Cantidad + ", '" + factura.Descripcion_mano_obra + "')", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }
        public void ConsultasObtenerPago(TextBox text, int id)
        {
            try
            {
                cmd = new SqlCommand("SELECT pago_dia from Trabajador WHERE id_trabajador = " + id + "", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    text.Text = Convert.ToString(reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }

        }

        public int ConsultasActualizar(Trabajadores trabajador, int id)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("UPDATE Trabajador SET nombre = '" + trabajador.Nombre + "', fecha_nacimiento = '" + trabajador.Fecha + "', dui = '" + trabajador.Dui + "', nit ='" + trabajador.Nit + "', afp = '" + trabajador.Afp + "', num_seguro = '" + trabajador.Seguro + "', direccion = '" + trabajador.Direccion + "', pago_dia = " + trabajador.Pago + ", num_telefono ='" + trabajador.Telefono + "', tipo = '" + trabajador.Tipo + "' WHERE id_trabajador = " + id + "", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }

        public int ConsultasActualizarInventario(Inventario inventario, int id)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("UPDATE Inventario SET descripcion = '" + inventario.Descripcion + "', existencia = " + inventario.Existencia + ", precio_compra = " + inventario.Precio_compra + ", precio_venta = " + inventario.Precio_venta + ", ruta_imagen = '" + inventario.Ruta_imagen + "' WHERE id_repuestos = " + id + "", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }

        public int ConsultasActualizarPlanilla(Planilla planilla, int id)
        {
            int resultado = 0;
            try
            {
                cmd = new SqlCommand("UPDATE Planilla SET id_trabajador = " + planilla.Id_trabajador + ", dias_trabajados = " + planilla.Dias_trabajados + ", inicio_ciclo = '" + planilla.Fecha_inicio + "', fin_ciclo = '" + planilla.Fecha_final + "', pago = " + planilla.Pago + " WHERE id_planilla = " + id + "", cn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception ex)
            {
                string Excepcion = Convert.ToString(ex);
            }
            return resultado;
        }

        public void ConsultasLlenar(DataGridView dgv, string tipo)
        {
            switch (tipo)
            {
                case "Trabajador":
                    try
                    {
                        da = new SqlDataAdapter("SELECT id_trabajador, nombre, fecha_nacimiento, dui, nit, afp, num_seguro, direccion, pago_dia, num_telefono, tipo From Trabajador", cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        string Excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Inventario":
                    try
                    {
                        da = new SqlDataAdapter("SELECT * From Inventario", cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string Excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Horario":
                    try
                    {
                        da = new SqlDataAdapter("SELECT * From Horario", cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string Excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Planilla":
                    try
                    {
                        da = new SqlDataAdapter("SELECT * From Planilla", cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string Excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Factura":
                    try
                    {
                        da = new SqlDataAdapter("SELECT * From Factura", cn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string Excepcion = Convert.ToString(ex);
                    }
                    break;
            }

        }

        public int ConsultasBorrar(int id, string tipo)
        {
            int resultado = 0;
            switch (tipo)
            {
                case "Trabajador":
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM Trabajador WHERE id_trabajador = " + id, cn);
                        cmd.ExecuteNonQuery();
                        resultado = 1;
                    }
                    catch (Exception ex)
                    {
                        string excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Inventario":
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM Inventario WHERE id_repuestos = " + id, cn);
                        cmd.ExecuteNonQuery();
                        resultado = 1;
                    }
                    catch (Exception ex)
                    {
                        string excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Horario":
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM Horario WHERE id_trabajador = " + id, cn);
                        cmd.ExecuteNonQuery();
                        resultado = 1;
                    }
                    catch (Exception ex)
                    {
                        string excepcion = Convert.ToString(ex);
                    }
                    break;
                case "Planilla":
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM Planilla WHERE id_planilla = " + id, cn);
                        cmd.ExecuteNonQuery();
                        resultado = 1;
                    }
                    catch (Exception ex)
                    {
                        string excepcion = Convert.ToString(ex);
                    }
                    break;
            }
            return resultado;
        }

        public void ConsultasLlenarCBX(ComboBox cbx)
        {
            try
            {
                cmd = new SqlCommand("SELECT Trabajador.nombre from Trabajador LEFT JOIN Horario ON Horario.id_trabajador = Trabajador.id_trabajador WHERE Horario.id_trabajador IS NULL", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbx.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }
        }

        public int ConsultasComprobacion(string nombre)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("SELECT id_trabajador From Trabajador WHERE nombre = '" + nombre + "'", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                }
            } catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }
            return id;
        }

        public List<string> ConsultasLlenarImgList()
        {
            List<string> paths = new List<string>();
            try
            {
                cmd = new SqlCommand("SELECT ruta_imagen from Inventario", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paths.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }
            return paths;
        }

        public int ConsultasObtenerIdRepuesto(String nombre)
        {
            int id_repuesto = 0;
            try
            {
                cmd = new SqlCommand("SELECT id_repuestos from Inventario WHERE descripcion = '" + nombre + "'", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_repuesto = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }
            return id_repuesto;
        }
        public float ConsultasObtenerPrecio(int id)
        {
            float precio = 0;
            try
            {
                cmd = new SqlCommand("SELECT precio_venta from Inventario WHERE id_repuestos = " + id + "", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    precio = float.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                string excepcion = Convert.ToString(ex);
            }
            return precio;
        }
        public void ConsultasAgregarHorario(int id)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO HORARIO(id_trabajador) VALUES(" + id + ")", cn);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ConsultasAgregarDia(string dia, int id)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Horario SET " + dia + " = 'T' WHERE id_trabajador = " + id, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ConsultasActualizarDia(int id)
        {
            try
            {
                cmd = new SqlCommand("Update Horario SET lunes = '', martes = '', miercoles = '', jueves = '', viernes = '', sabado = '', domingo = '' WHERE id_trabajador = " + id, cn);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
