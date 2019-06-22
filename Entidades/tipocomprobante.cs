using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class tipocomprobante
    {
        [Key]
        public int idtipocomprobante { get; set; }
        public string nombrecomprobante { get; set; }
    }
}
