using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    class Planilla
    {
        int dias_trabajados, id_trabajador;
        DateTime fecha_inicio;
        DateTime fecha_final;
        float pago;

        public int Id_trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
        }
        public int Dias_trabajados
        {
            get { return dias_trabajados; }
            set { dias_trabajados = value; }
        }
        public DateTime Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public DateTime Fecha_final
        {
            get { return fecha_final; }
            set { fecha_final = value; }
        }
        public float Pago
        {
            get { return pago; }
            set { pago = value; }
        }
    }
}
