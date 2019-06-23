using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6JuanFcoR.BLL;
using Tarea6JuanFcoR.Entidades;

namespace Tarea6JuanFcoRTests3.Entidades
{
    [TestClass()]
    public class detalleventaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<detalleventa> db = new RepositorioBase<detalleventa>();
            detalleventa p = new detalleventa();
            p.iddetalleventa = 1;
            p.venta_idventa = 2;
            p.costounidad = 22;
            p.producto_idproducto = 21;
            p.total = 24;
            p.unidades = 11;

            RepositorioBase<detalleventa> repositorio = new RepositorioBase<detalleventa>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<detalleventa> repositorio = new RepositorioBase<detalleventa>();
            bool paso = false;
            detalleventa p = repositorio.Buscar(1);
            p.costounidad = 32;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<detalleventa> repositorio = new RepositorioBase<detalleventa>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<detalleventa> repositorio = new RepositorioBase<detalleventa>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<detalleventa> repositorio = new RepositorioBase<detalleventa>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
