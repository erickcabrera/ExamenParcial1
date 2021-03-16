using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace SistemaInventario
{
    public partial class Form1 : Form
    {   

        public string contra;
        public Form1()
        {
            InitializeComponent();
        }
        //Registrarse
        //NOTA: Agregar el atributo tipo pero con permiso del Gerente
        private void button2_Click(object sender, EventArgs e)
        {
        

        }

        //Loguearse
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Conexion cn = new Conexion();
            //Validar el usuario y el password
            if (cn.Consultas(Convert.ToString(txtuser.Text), Convert.ToString(txtpass.Text)) > 0) 
                {
                    MessageBox.Show("Ingreso exitoso, bienvenido");    
                
                ///Esto no
                //Agregar swich para cada tipo de usuario
                /*switch (Login.Usuario)
                {
                    case "Gerente":
                        Gerente_Platform formulario = new Gerente_Platform();
                        formulario.Show();
                        break;
                    case "Trabajador":
                        Trabajador_Platform formulario2 = new Trabajador_Platform();
                        formulario2.Show();
                        break;
                    case "Auxiliar":
                        Auxiliar_Platform formulario3 = new Auxiliar_Platform();
                        formulario3.Show();
                        break;
                    case "Secretaria":
                        Secretaria_Platform formulario4 = new Secretaria_Platform();
                        formulario4.Show();
                        break;
                }
                
                Menú menu = new Menú();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
