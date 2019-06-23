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
    public class permisoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<permiso> db = new RepositorioBase<permiso>();
            permiso p = new permiso();
            p.idpermiso = 1;
            p.funcionalidad = "node";
            p.descripcion = "qweqw";

            RepositorioBase<permiso> repositorio = new RepositorioBase<permiso>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<permiso> repositorio = new RepositorioBase<permiso>();
            bool paso = false;
            permiso p = repositorio.Buscar(1);
            p.descripcion = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<permiso> repositorio = new RepositorioBase<permiso>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<permiso> repositorio = new RepositorioBase<permiso>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<permiso> repositorio = new RepositorioBase<permiso>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
