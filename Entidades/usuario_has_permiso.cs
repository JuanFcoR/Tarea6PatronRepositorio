using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class usuario_has_permiso
    {
        [Key]
        public int usuario_idusuario { get; set; }
        public int idpermiso { get; set; }
    }
}
