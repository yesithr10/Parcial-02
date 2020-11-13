using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;

namespace Logica
{
    public class TerceroService
    {

        private readonly DbContext _context;
        public TerceroService(DbContext context)
        {
            _context = context;
        }
        public List<Tercero> Consultar()
        {
            List<Tercero> terceros = _context.Terceros.ToList();
            return terceros;
        }
        public GuardarTerceroResponse Guardar(Tercero tercero)
        {
            try
            {
                var terceroBuscado = _context.Terceros.Find(tercero.Cedula);
                if (terceroBuscado != null)
                {
                    return new GuardarTerceroResponse("Error el tercero ya esta registrado)");
                }
                _context.Terceros.Add(tercero);
                _context.SaveChanges();
                return new GuardarTerceroResponse(tercero);
            }
            catch(Exception e)
            {
                return new GuardarTerceroResponse($"Error de la pagina: {e.Message}");
            }
        }
    }
    public class GuardarTerceroResponse
    {
        public GuardarTerceroResponse(string mensaje)
        {
            Alerta = true;
            Mensaje = mensaje;
        }
        public GuardarTerceroResponse(Tercero tercero)
        {
            Alerta = false;
            Tercero = Tercero;
        }
        public bool Alerta { get; set; }
        public string Mensaje { get; set; }
        public Tercero Tercero { get; set; }
    }
}
