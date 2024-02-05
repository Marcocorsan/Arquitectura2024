using Aplicacion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services
{
    public class EFMarcacionesRepository : IMarcacionesRepository
    {
        private MarcacionesContext context;

        public EFMarcacionesRepository(MarcacionesContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Marcaciones> Marcaciones => context.Marcaciones;

        public Marcaciones GetMarcacion(int id)
        {
            return context.Marcaciones.Find(id);
        }



    }
}
