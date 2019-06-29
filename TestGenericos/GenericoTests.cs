using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudianteInscripcionProyecto.DAL;
using EstudianteInscripcionProyecto.BLL;
using EstudianteInscripcionProyecto.Entidades;

namespace TestGenericos
{
    [TestClass]
    public class GenericoTests
    {
        [TestMethod]
        public void GuardarEstudiante()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 1;
            estudiantes.Balance = 12121;
            estudiantes.FechaIngreso = DateTime.Now;
            estudiantes.Nombres = "Nombre";

            Assert.IsTrue(repositorioBaseBLL.Guardar(estudiantes));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Assert.IsNotNull(repositorioBaseBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Assert.IsNotNull(repositorioBaseBLL.GetList(p => true));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 1;
            estudiantes.Balance = 1212;
            estudiantes.Nombres = "al;skd";
            estudiantes.FechaIngreso = DateTime.Now;
            Assert.IsTrue(repositorioBaseBLL.Modificar(estudiantes));
        }

        [TestMethod()]
        public void EliminarEstudiante()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Assert.IsTrue(repositorioBaseBLL.Eliminar(1));
        }
    }
}
