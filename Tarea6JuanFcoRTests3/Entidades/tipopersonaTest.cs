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
    public class tipopersonaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<tipopersona> db = new RepositorioBase<tipopersona>();
            tipopersona p = new tipopersona();
            p.idtipopersona = 1;
            p.nombre = "Nada";

            RepositorioBase<tipopersona> repositorio = new RepositorioBase<tipopersona>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<tipopersona> repositorio = new RepositorioBase<tipopersona>();
            bool paso = false;
            tipopersona p = repositorio.Buscar(1);
            p.nombre = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<tipopersona> repositorio = new RepositorioBase<tipopersona>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<tipopersona> repositorio = new RepositorioBase<tipopersona>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<tipopersona> repositorio = new RepositorioBase<tipopersona>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
