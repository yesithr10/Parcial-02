using System;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    private readonly TerceroContext _context;

    public class TerceroService (TerceroContext context)
    {
        _context=context;
    }
}
