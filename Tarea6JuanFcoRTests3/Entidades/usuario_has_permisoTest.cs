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
    public class usuario_has_permisoTest
    {
        private int idusuario_has_permiso;

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<usuario_has_permiso> db = new RepositorioBase<usuario_has_permiso>();
            usuario_has_permiso p = new usuario_has_permiso();
            p.usuario_idusuario = 1;
            p.idpermiso = 21;
            

            RepositorioBase<usuario_has_permiso> repositorio = new RepositorioBase<usuario_has_permiso>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<usuario_has_permiso> repositorio = new RepositorioBase<usuario_has_permiso>();
            bool paso = false;
            usuario_has_permiso p = repositorio.Buscar(1);
            p.idpermiso = 24;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<usuario_has_permiso> repositorio = new RepositorioBase<usuario_has_permiso>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<usuario_has_permiso> repositorio = new RepositorioBase<usuario_has_permiso>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<usuario_has_permiso> repositorio = new RepositorioBase<usuario_has_permiso>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}

