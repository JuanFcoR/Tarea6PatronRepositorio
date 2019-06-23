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
    public class unidadmedidaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<unidadmedida> db = new RepositorioBase<unidadmedida>();
            unidadmedida p = new unidadmedida();
            p.idunidadmedida = 1;
            p.nombreunidad = "Metro";

            RepositorioBase<unidadmedida> repositorio = new RepositorioBase<unidadmedida>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<unidadmedida> repositorio = new RepositorioBase<unidadmedida>();
            bool paso = false;
            unidadmedida p = repositorio.Buscar(1);
            p.nombreunidad = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<unidadmedida> repositorio = new RepositorioBase<unidadmedida>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<unidadmedida> repositorio = new RepositorioBase<unidadmedida>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<unidadmedida> repositorio = new RepositorioBase<unidadmedida>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
