using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    class Factura
    {
        private string nombre;
        private int cantidad, id_repuesto;
        private float costo, precio;

        public string Nombre
        {
            get{return nombre;}
            set { nombre = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public int Id_repuesto
        {
            get { return id_repuesto; }
            set { id_repuesto = value; }
        }
    }
}
