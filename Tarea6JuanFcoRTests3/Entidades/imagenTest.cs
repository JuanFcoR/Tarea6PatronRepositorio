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
    public class imagenTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<imagen> db = new RepositorioBase<imagen>();
           imagen p = new imagen();
            p.idimagen = 1;
            p.rutaimagen = "123";

            RepositorioBase<imagen> repositorio = new RepositorioBase<imagen>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<imagen> repositorio = new RepositorioBase<imagen>();
            bool paso = false;
            imagen p = repositorio.Buscar(1);
            p.rutaimagen = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<imagen> repositorio = new RepositorioBase<imagen>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<imagen> repositorio = new RepositorioBase<imagen>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<imagen> repositorio = new RepositorioBase<imagen>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
