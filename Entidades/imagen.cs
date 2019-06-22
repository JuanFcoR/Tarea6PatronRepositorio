using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class imagen
    {
        [Key]
        public int idimagen { get; set; }
        public string rutaimagen { get; set; }
    }
}
