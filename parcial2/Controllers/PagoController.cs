using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;
using Logica;
using Datos;
using Parcial2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly PagoService _pagoService;
        public PagoController(DbContext context)
        {
            _pagoService = new PagoService(context);
        }
        // GET: api/<PagoController>
        [HttpGet]
        public IEnumerable<PagoViewModel> Get()
        {
            var pagos = _pagoService.Consultar().Select(i => new PagoViewModel(i));
            return pagos;
        }

        // GET api/<PagoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PagoController>
        [HttpPost]
        public ActionResult<PagoViewModel> Post(PagoInputModel pagoInput)
        {
            Pago pago = MapearPago(pagoInput);
            var respuesta = _pagoService.Guardar(pago);
            if (respuesta.Alerta)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Pago);
        }
        

        // PUT api/<PagoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PagoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public Pago MapearPago(PagoInputModel pagoinput)
        {
            var pago = new Pago
            {
                Codigo = pagoinput.Codigo,
                TipoPago = pagoinput.TipoPago,
                Fecha = pagoinput.Fecha,
                Valor = pagoinput.Valor,
                ValorIva = pagoinput.ValorIva
        };
            return pago;
        }
    }
}
