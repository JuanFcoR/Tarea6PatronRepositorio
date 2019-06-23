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
    public class personaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<persona> db = new RepositorioBase<persona>();
            persona p = new persona();
            p.idpersona= 1;
            p.dni = 1;
            p.nombre = "cgdfdh";
            p.materno = "cv";
            p.paterno = "fhdgghd";
            p.fechanacimiento = DateTime.Now;
            p.telefono = "123456";
            p.correo = "fdgfd@gmail.com";
            p.sexo = 'm';
            p.idimagen = 1;
            p.direccion = "dfgdgfdgh";
            p.idtipopersona = 1;

            RepositorioBase<persona> repositorio = new RepositorioBase<persona>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<persona> repositorio = new RepositorioBase<persona>();
            bool paso = false;
            persona p = repositorio.Buscar(1);
            p.nombre = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<persona> repositorio = new RepositorioBase<persona>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<persona> db = new RepositorioBase<persona>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<persona> db = new RepositorioBase<persona>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}
