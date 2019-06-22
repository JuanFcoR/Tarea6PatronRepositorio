using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class cliente
    {
        [Key]
        public int idcliente { get; set; }
        public string Descripcion { get; set; }
    }
}
