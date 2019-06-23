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
    public class proveedorTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<proveedor> db = new RepositorioBase<proveedor>();
            proveedor p = new proveedor();
            p.idprovedor = 1;
            p.persona_idpersona = 9;

            RepositorioBase<proveedor> repositorio = new RepositorioBase<proveedor>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<proveedor> repositorio = new RepositorioBase<proveedor>();
            bool paso = false;
            proveedor p = repositorio.Buscar(1);
            p.persona_idpersona = 5;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<proveedor> repositorio = new RepositorioBase<proveedor>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<proveedor> repositorio = new RepositorioBase<proveedor>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<proveedor> repositorio = new RepositorioBase<proveedor>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
