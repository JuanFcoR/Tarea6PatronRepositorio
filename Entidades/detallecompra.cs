using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class detallecompra
    {
        [Key]
        public Int64  iddetallecompra { get; set; }
        public int compra_idcompra { get; set; }
        public int producto_idproducto { get; set; }
        public double unidades { get; set; }
        public double costounidad { get; set; }
        public double total { get; set; }

        public detallecompra(long iddetallecompra, int compra_idcompra, int producto_idproducto, double unidades, double costounidad, double total)
        {
            this.iddetallecompra = iddetallecompra;
            this.compra_idcompra = compra_idcompra;
            this.producto_idproducto = producto_idproducto;
            this.unidades = unidades;
            this.costounidad = costounidad;
            this.total = total;
        }

        public detallecompra()
        {
            iddetallecompra = 0;
            compra_idcompra = 0;
            producto_idproducto=0;
            unidades = 0;
            costounidad = 0;
            total = 0;
        }
    }
    }

    
}
