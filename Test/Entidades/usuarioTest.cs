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
    public class usuarioTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<usuario> db = new RepositorioBase<usuario>();
            usuario p = new usuario();
            p.idusuario = 1;
            p.clave = "123";
            p.empleado_idempleado = 312;
            p.nombreusuario = "Juan";

            RepositorioBase<usuario> repositorio = new RepositorioBase<usuario>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<usuario> repositorio = new RepositorioBase<usuario>();
            bool paso = false;
            usuario p = repositorio.Buscar(1);
            p.nombreusuario = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<usuario> repositorio = new RepositorioBase<usuario>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<usuario> repositorio = new RepositorioBase<usuario>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<usuario> repositorio = new RepositorioBase<usuario>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}

