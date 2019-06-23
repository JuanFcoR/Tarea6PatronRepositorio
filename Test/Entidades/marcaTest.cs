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
    public class marcaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<marca> db = new RepositorioBase<marca>();
            marca p = new marca();
            p.idmarca = 1;
            p.nombremarca = "Etc";

            RepositorioBase<marca> repositorio = new RepositorioBase<marca>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<marca> repositorio = new RepositorioBase<marca>();
            bool paso = false;
            marca p = repositorio.Buscar(1);
            p.nombremarca = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<marca> repositorio = new RepositorioBase<marca>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<marca> repositorio = new RepositorioBase<marca>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<marca> repositorio = new RepositorioBase<marca>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
