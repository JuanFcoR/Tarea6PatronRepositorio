using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class modelo
    {
        [Key]
        public int idmodelo { get; set; }
        public string nombreunidad { get; set; }
    }
}
