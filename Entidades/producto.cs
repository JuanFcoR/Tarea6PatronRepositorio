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
        public string fechafabricacion { get; set; }
        public double costocompra { get; set; }
        public double stock { get; set; }
        public int unidadmedida_idunidadmedida { get; set; }
        public int imagen_idimagen { get; set; }
        public int categoria_idcategoria { get; set; }
        public int marca_idmarca { get; set; }
        public int modelo_idmodelo { get; set; }
    }
}
