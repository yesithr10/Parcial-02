using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;

namespace Parcial2.Models
{
    public class PagoInputModel
    {
        public string Codigo { get; set; }
        public string TipoPago { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public float ValorIva { get; set; }
    }
    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel()
        {

        }
        public PagoViewModel(Pago pago)
        {
            Codigo = pago.Codigo;
            TipoPago = pago.TipoPago;
            Fecha = pago.Fecha;
            Valor = pago.Valor;
            ValorIva = pago.ValorIva;
        }
    }
   
}
