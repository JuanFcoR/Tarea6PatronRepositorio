using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class categoria
    {
        [Key]
        public int idcategoria { get; set; }
        public string nombrecategoria { get; set; }
        public string descripcion { get; set; }

        public categoria()
        {
            idcategoria = 0;
            nombrecategoria = string.Empty;
            descripcion = string.Empty;
        }
    }
}
