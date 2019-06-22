using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class unidadmedida
    {
        [Key]
        public int idunidadmedida { get; set; }
        public string nombreunidad { get; set; }
        
    }
}
