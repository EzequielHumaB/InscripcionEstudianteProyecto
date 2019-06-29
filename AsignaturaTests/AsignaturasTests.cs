using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.BLL;

namespace AsignaturaTests
{
    [TestClass]
    public class AsignaturasTests
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = 1;
            asignaturas.Creditos = 12;
            asignaturas.Descripcion = "sd;lk";
            Assert.IsTrue(repositorioBaseBLL.Guardar(asignaturas));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            Assert.IsNotNull(repositorioBaseBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            Assert.IsNotNull(repositorioBaseBLL.GetList(p=>true));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = 1;
            asignaturas.Creditos = 12;
            asignaturas.Descripcion = "Descripcion";
            Assert.IsTrue(repositorioBaseBLL.Modificar(asignaturas));
        }
        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            Assert.IsTrue(repositorioBaseBLL.Eliminar(1));
        }
    }
}
