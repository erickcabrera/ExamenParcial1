using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    class Factura2 : Factura
    {
        float valor_mano_obra, costo_total;
        int id_trabajador;
        string descripcion_mano_obra, id_repuestos, repuestos;

        public string Repuestos
        {
            get { return repuestos; }
            set { repuestos = value; }
        }
        public string Id_repuestos
        {
            get { return id_repuestos; }
            set { id_repuestos = value; }
        }

        public string Descripcion_mano_obra
        {
            get { return descripcion_mano_obra; }
            set { descripcion_mano_obra = value; }
        }
        public int Id_trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
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
