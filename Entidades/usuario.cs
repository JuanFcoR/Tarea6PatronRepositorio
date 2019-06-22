using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class usuario
    {
        [Key]
        public int idusuario { get; set; }
        public int empleado_idempleado { get; set; }
        public string nombreusuario { get; set; }
        public string clave { get; set; }
    }
}
