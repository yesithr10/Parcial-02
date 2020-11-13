using System.Text;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Pago
    {
        [Key]
        public string Codigo { get; set; }
        public string TipoPago { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public float ValorIva { get; set; }
    }
}