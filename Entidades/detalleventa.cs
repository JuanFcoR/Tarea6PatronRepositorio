using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class detalleventa
    {
        [Key]   
        public Int64 iddetalleventa { get; set; }
        public int venta_idventa { get; set; }
        public int producto_idproducto { get; set; }
        public double unidades { get; set; }
        public double costounidad { get; set; }
        public double descuentounidad  { get; set; }
        public double total { get; set; }
    }
}
