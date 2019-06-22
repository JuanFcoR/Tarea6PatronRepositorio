using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class cargo
    {

        [Key]
        public int idcargo { get; set; }
        public string nombrecargo { get; set; }
        public int estado_idestado { get; set; }

        public cargo()
        {
            idcargo = 0;
            nombrecargo = string.Empty;
            estado_idestado = 0;
        }
    }
}
