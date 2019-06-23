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
    public class tipocomprobanteTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<tipocomprobante> db = new RepositorioBase<tipocomprobante>();
            tipocomprobante p = new tipocomprobante();
            p.idtipocomprobante = 1;
            p.nombrecomprobante="NCF"

            RepositorioBase<tipocomprobante> repositorio = new RepositorioBase<tipocomprobante>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<tipocomprobante> repositorio = new RepositorioBase<tipocomprobante>();
            bool paso = false;
            tipocomprobante p = repositorio.Buscar(1);
            p.nombrecomprobante = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<tipocomprobante> repositorio = new RepositorioBase<tipocomprobante>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<tipocomprobante> repositorio = new RepositorioBase<tipocomprobante>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<tipocomprobante> repositorio = new RepositorioBase<tipocomprobante>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
