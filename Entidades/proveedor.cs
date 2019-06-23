using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class proveedor
    {
        [Key]
        public int idprovedor { get; set; }
        public int persona_idpersona { get; set; }
    }
}
