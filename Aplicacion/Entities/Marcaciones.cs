using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Entities
{
    public class Marcaciones
    {
        public int idMarcaciones { get; set; }
        public int credencial { get; set; }
        public DateTime fechaMarcacion { get; set; }
        public TimeSpan horaMarcacion { get; set; }        
        public int estado { get; set; }     
    }
}
