using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    class Factura
    {
        private int cantidad, idfactua;
        private float costo;

        public int Idfactua
        {
            get { return idfactua; }
            set { idfactua = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
      
        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }
     

        //Metodos traidos de factura 2

        float valor_mano_obra, costo_total;
      
        string descripcion_mano_obra;

     
     
        public string Descripcion_mano_obra
        {
            get { return descripcion_mano_obra; }
            set { descripcion_mano_obra = value; }
        }
     
        public float Valor_mano_obra
        {
            get { return valor_mano_obra; }
            set { valor_mano_obra = value; }
        }
        public float Costo_total
        {
            get { return costo_total; }
            set { costo_total = value; }
        }
    }
}
