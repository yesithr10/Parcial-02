using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;

namespace Parcial2.Models
{
    public class TerceroInputModel
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }

    }
    public class TerceroViewModel : TerceroInputModel
    {
        public TerceroViewModel()
        {

        }
        public TerceroViewModel(Tercero tercero)
        {
            Cedula = tercero.Cedula;
            Nombre = tercero.Nombre;
            Direccion = tercero.Direccion;
            Telefono = tercero.Telefono;
            Pais = tercero.Pais;
            Departamento = tercero.Departamento;
            Ciudad = tercero.Ciudad;
        }
    }
}
