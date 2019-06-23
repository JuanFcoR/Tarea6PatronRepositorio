using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6JuanFcoR.Entidades;

namespace Tarea6JuanFcoR.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<cargo> cargo { get; set; }
        public DbSet<cliente> cliente { get; set; }
        public DbSet<categoria> categoria { get; set; }
        public DbSet<producto> producto { get; set; }
        public DbSet<compra> compra { get; set; }
        public DbSet<detallecompra> detallecompra { get; set; }
        public DbSet<detalleventa> detalleventa { get; set; }
        public DbSet<empleado> empleado { get; set; }
        public DbSet<estado> estado { get; set; }
        public DbSet<imagen> imagen { get; set; }
        public DbSet<marca> marca { get; set; }
        public DbSet<modelo> modelo { get; set; }
        public DbSet<permiso> permiso { get; set; }
        public DbSet<persona> persona { get; set; }
        public DbSet<tipocomprobante> tipocomprobante { get; set; }
        public DbSet<proveedor> proveedor{ get; set; }
        public DbSet<tipopersona> tipopersona { get; set; }
        public DbSet<unidadmedida> unidadmedida { get; set; }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<usuario_has_permiso> usuario_has_permiso { get; set; }
        public DbSet<venta> venta { get; set; }


        public Contexto() : base("ConStr") { }
    }
}
