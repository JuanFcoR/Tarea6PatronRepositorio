using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class producto
    {
        [Key]

        public Int64 idproducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechafabricacion { get; set; }
        public double costocompra { get; set; }
        public double stock { get; set; }
        public int idunidadmedida { get; set; }
        public int idimagen { get; set; }
        public int idcategoria { get; set; }
        public int idmarca { get; set; }
        public int idmodelo { get; set; }

        public producto()
        {

        }
    }
}
