using Entidad;
using Microsoft.AspNetCore.Mvc;
using Parcial2.Models;
using System.Collections.Generic;
using Logica;
using Datos;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerceroController : ControllerBase
    {
        private readonly TerceroService _terceroService;
        public TerceroController(DbContext context)
        {
            _terceroService = new TerceroService(context);
        }
        // GET: api/<TerceroController>
        [HttpGet]
        public IEnumerable<TerceroViewModel> Get()
        {
            var terceros = _terceroService.Consultar().Select(i => new TerceroViewModel(i));
            return terceros;
        }
        // GET api/<TerceroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TerceroController>
        [HttpPost]
        public ActionResult<TerceroViewModel> Post(TerceroInputModel terceroInput)
        {
            Tercero tercero = MapearTercero(terceroInput);
            var respuesta = _terceroService.Guardar(tercero);
            if (respuesta.Alerta)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Tercero);
        }
        

        // PUT api/<TerceroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TerceroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public Tercero MapearTercero(TerceroInputModel terceroInput)
        {
            var tercero = new Tercero
            {
                Cedula = terceroInput.Cedula,
                Nombre = terceroInput.Nombre,
                Direccion = terceroInput.Direccion,
                Telefono = terceroInput.Telefono,
                Pais = terceroInput.Pais,
                Departamento = terceroInput.Departamento,
                Ciudad = terceroInput.Ciudad
            };
            return tercero;
        }
    }
}
