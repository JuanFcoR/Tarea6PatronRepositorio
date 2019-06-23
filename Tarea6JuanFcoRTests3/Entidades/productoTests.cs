using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea6JuanFcoR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6JuanFcoR.BLL;

namespace Tarea6JuanFcoRTests3.Entidades
{

    [TestClass()]
    public class productoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<producto> db = new RepositorioBase<producto>();
            bool paso = false;
            producto p = new producto();

            p.idproducto = 1;
            p.nombre = "sdfgsdsdsdd";
            p.descripcion = "esrdsddsg";
            p.fechafabricacion = DateTime.Now;
            p.costocompra = 23442;
            p.stock = 10;
            p.idunidadmedida = 1;
            p.idimagen = 1;
            p.idcategoria = 1;
            p.idmarca = 1;
            p.idmodelo = 1;

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<producto> repositorio = new RepositorioBase<producto>();
            bool paso = false;
            producto p = repositorio.Buscar(1);

            p.nombre = "asda";

            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            RepositorioBase<producto> db = new RepositorioBase<producto>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            RepositorioBase<producto> db = new RepositorioBase<producto>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            RepositorioBase<producto> db = new RepositorioBase<producto>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}