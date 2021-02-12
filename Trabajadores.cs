using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    class Trabajadores
    {
        string nombre, dui, nit, afp, seguro, direccion, telefono, tipo;
        float pago;
        DateTime fecha;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public String Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public String Afp
        {
            get { return afp; }
            set { afp = value; }
        }
        public String Seguro
        {
            get { return seguro; }
            set { seguro = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public float Pago
        {
            get { return pago; }
            set { pago = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
