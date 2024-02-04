using Aplicacion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public interface IMarcacionesRepository
    {
        IEnumerable<Marcaciones> Marcaciones { get; }
    }
}
