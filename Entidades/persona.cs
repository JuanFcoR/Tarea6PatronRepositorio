using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class persona
    {
        [Key]
        public Int64 idpersona { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string materno { get; set; }
        public string paterno { get; set; }
        public DateTime fechanacimiento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public char sexo { get; set; }
        public int imagen_idimagen { get; set; }
        public string direccion { get; set; }
        public int tipopersona_idtipopersona { get; set; }
    }
}
