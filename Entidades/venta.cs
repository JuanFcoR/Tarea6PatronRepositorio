using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class venta
    {
        [Key]
        public Int64 idventa { get; set; }
        public int usuario_idusuario { get; set; }
        public int cliente_idcliente { get; set; }
        public int comprobante_tipocomprobante { get; set; }
        public DateTime fecheventa { get; set; }
        public double igv { get; set; }
        public double subtotal { get; set; }
        public double costoventa { get; set; }
        List<detalleventa> detalle;

        public venta()
        {
            idventa = 0;
            usuario_idusuario = 0;
            cliente_idcliente = 0;
            comprobante_tipocomprobante = 0;
            fecheventa = DateTime.Now;
            igv = 0;
            subtotal = 0;
            costoventa = 0;
            detalle = new List<detalleventa>();

        }
    }
}
