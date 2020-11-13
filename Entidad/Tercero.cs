using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Tercero
    {
        [Key]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public List<Pago> Pagos { get; set; }
    }
}
