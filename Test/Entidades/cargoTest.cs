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
    public class cargoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<cargo> db = new RepositorioBase<cargo>();
            cargo p = new cargo();
            p.idcargo = 1;
            p.nombrecargo = "hkdj";
            p.estado_idestado = 3;

            RepositorioBase<cargo> repositorio = new RepositorioBase<cargo>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<cargo> repositorio = new RepositorioBase<cargo>();
            bool paso = false;
            cargo p = repositorio.Buscar(1);
            p.nombrecargo = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<cargo> repositorio = new RepositorioBase<cargo>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<cargo> repositorio = new RepositorioBase<cargo>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<cargo> repositorio = new RepositorioBase<cargo>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
