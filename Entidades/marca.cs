using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class marca
    {
        [Key]
        public int idmarca { get; set; }
        public string nombremarca { get; set; }
    }
}
