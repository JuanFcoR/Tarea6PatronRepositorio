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
    public class empleadoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<empleado> db = new RepositorioBase<empleado>();
            empleado p = new empleado();
            p.idempleado = 1;
            p.cargo_cargoid = 2;
            p.estado_idestado = 1;
            p.persona_idpersona = 21;

            RepositorioBase<empleado> repositorio = new RepositorioBase<empleado>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<empleado> repositorio = new RepositorioBase<empleado>();
            bool paso = false;
            empleado p = repositorio.Buscar(1);
            p.cargo_cargoid = 31;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<empleado> repositorio = new RepositorioBase<empleado>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<empleado> repositorio = new RepositorioBase<empleado>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<empleado> repositorio = new RepositorioBase<empleado>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
