using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class empleado
    {
        [Key]
        public int idempleado { get; set; }
        public int estado_idestado { get; set; }
        public int cargo_cargoid { get; set; }
        public int persona_idpersona { get; set; }
    }
}
