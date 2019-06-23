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
    [TestClass() ]
    public class detallecompraTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<detallecompra> db = new RepositorioBase<detallecompra>();
            detallecompra p = new detallecompra();
            p.iddetallecompra = 1;
            p.compra_idcompra = 2;
            p.costounidad = 22;
            p.producto_idproducto = 21;
            p.total = 24;
            p.unidades = 11;

            RepositorioBase<detallecompra> repositorio = new RepositorioBase<detallecompra>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<detallecompra> repositorio = new RepositorioBase<detallecompra>();
            bool paso = false;
            detallecompra p = repositorio.Buscar(1);
            p.costounidad = 32;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<detallecompra> repositorio = new RepositorioBase<detallecompra>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<detallecompra> repositorio = new RepositorioBase<detallecompra>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<detallecompra> repositorio = new RepositorioBase<detallecompra>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }  
    }
}
