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
    public class categoriaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<categoria> db = new RepositorioBase<categoria>();
            categoria p = new categoria();
            p.idcategoria = 1;
            p.nombrecategoria = "dsd";
            p.descripcion = "qweqw";

            RepositorioBase<categoria> repositorio = new RepositorioBase<categoria>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<categoria> repositorio = new RepositorioBase<categoria>();
            bool paso = false;
            categoria p = repositorio.Buscar(1);
            p.descripcion = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<categoria> repositorio = new RepositorioBase<categoria>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<categoria> repositorio = new RepositorioBase<categoria>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<categoria> repositorio = new RepositorioBase<categoria>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
