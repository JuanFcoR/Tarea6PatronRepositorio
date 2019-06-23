using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class compra
    {
        [Key]
        public int idcompra { get; set; }
        public int usuario_usuarioid { get; set; }
        public DateTime fechacompra { get; set; }
        public int provedor_idprovedor { get; set; }
        public int tipocomprobante_idtipocomprobante { get; set; }
        public double costocompra { get; set; }

        public List<detallecompra> detalle;

        public compra()
        {
            idcompra = 0;
            usuario_usuarioid = 0;
            fechacompra = DateTime.Now;
            provedor_idprovedor = 0;
            tipocomprobante_idtipocomprobante = 0;
            costocompra = 0;
            detalle = new List<detallecompra>();
        }

    }
}
