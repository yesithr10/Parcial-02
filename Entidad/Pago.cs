using System.Text;
using System;

namespace Entidad
{
    public class Pago
    {
        public string Codigo { get; set; }
        public string TipoPago { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public float ValorIva { get; set; }
    }
}