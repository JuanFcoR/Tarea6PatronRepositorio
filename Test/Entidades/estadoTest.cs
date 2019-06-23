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
    public class estadoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<estado> db = new RepositorioBase<estado>();
            estado p = new estado();
            p.idestado = 1;
            p.fechafin = DateTime.Now;
            p.fechainicio = DateTime.Now;
            p.varchar = "var";

            RepositorioBase<estado> repositorio = new RepositorioBase<estado>();

            bool paso = false;

            paso = repositorio.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<estado> repositorio = new RepositorioBase<estado>();
            bool paso = false;
            estado p = repositorio.Buscar(1);
            p.varchar = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<estado> repositorio = new RepositorioBase<estado>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<estado> repositorio = new RepositorioBase<estado>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<estado> repositorio = new RepositorioBase<estado>();
            Assert.IsTrue(repositorio.Eliminar(1));

        } 
    }
}
