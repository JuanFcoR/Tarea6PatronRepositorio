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
    public class clienteTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<cliente> db = new RepositorioBase<cliente>();
            cliente p = new cliente();
            p.idcliente = 1;
            p.Descripcion = "Bleh";

            RepositorioBase<cliente> repositorio = new RepositorioBase<cliente>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<cliente> repositorio = new RepositorioBase<cliente>();
            bool paso = false;
            cliente p = repositorio.Buscar(1);
            p.Descripcion = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<cliente> repositorio = new RepositorioBase<cliente>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<cliente> repositorio = new RepositorioBase<cliente>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<cliente> repositorio = new RepositorioBase<cliente>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
