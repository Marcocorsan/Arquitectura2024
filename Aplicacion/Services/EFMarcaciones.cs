using Aplicacion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public  class EFMarcaciones : IMarcacionesRepository
    {
        private MarcacionesContext context;

            public EFMarcaciones(MarcacionesContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Marcaciones> Marcaciones => context.Marcaciones;
       

    }
}
