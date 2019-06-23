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
    public class modeloTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<modelo> db = new RepositorioBase<modelo>();
            modelo p = new modelo();
            p.idmodelo = 1;
            p.nombreunidad = "Nada";

            RepositorioBase<modelo> repositorio = new RepositorioBase<modelo>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<modelo> repositorio = new RepositorioBase<modelo>();
            bool paso = false;
            modelo p = repositorio.Buscar(1);
            p.nombreunidad  = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<modelo> repositorio = new RepositorioBase<modelo>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<modelo> repositorio = new RepositorioBase<modelo>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<modelo> repositorio = new RepositorioBase<modelo>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
