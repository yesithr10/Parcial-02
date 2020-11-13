using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidad;

namespace Logica
{
    public class PagoService
    {
        private readonly DbContext _context;
        public PagoService(DbContext context)
        {
            _context = context;
        }
        public List<Pago> Consultar()
        {
            List<Pago> pagos = _context.Pagos.ToList();
            return pagos;
        }
        public GuardarPagoResponse Guardar(Pago pago)
        {
            try
            {
                var pagoBuscado = _context.Pagos.Find(pago.Codigo);
                if (pagoBuscado != null)
                {
                    return new GuardarPagoResponse("Error el tercero ya esta registrado)");
                }
                _context.Pagos.Add(pago);
                _context.SaveChanges();
                return new GuardarPagoResponse(pago);
            }
            catch (Exception e)
            {
                return new GuardarPagoResponse($"Error de la pagina: {e.Message}");
            }
        }
    }
    public class GuardarPagoResponse
    {
        public GuardarPagoResponse(string mensaje)
        {
            Alerta = true;
            Mensaje = mensaje;
        }
        public GuardarPagoResponse(Pago pago)
        {
            Alerta = false;
            Pago = Pago;
        }
        public bool Alerta { get; set; }
        public string Mensaje { get; set; }
        public Pago Pago { get; set; }
    }
}
