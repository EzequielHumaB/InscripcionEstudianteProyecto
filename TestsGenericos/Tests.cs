using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.BLL;
using EstudianteInscripcionProyecto.DAL;
using System.Collections.Generic;

namespace TestsGenericos
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Guardar()
        {
            Inscripciones inscripciones = new Inscripciones();
            inscripciones.InscripcionesId = 1;
            inscripciones.FechaInscripcion = DateTime.Now;
            inscripciones.Monto = 1212;

            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 1;

            inscripciones.DetalleInscripciones.Add(new DetalleInscripciones()
            {
                DetalleInscripcionId = 1,
                InscripcionesId = 1,
                EstudianteId = 1,
                Balance = 1212,
            }); 
            
              
            Assert.IsTrue(InscripcionesBLL.Guardar(inscripciones));
        }

      
        [TestMethod()]
        public void Buscar()
        {
            Inscripciones inscripciones = new Inscripciones();
            Assert.IsNotNull(InscripcionesBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            Inscripciones inscripciones = new Inscripciones();
            Assert.IsNotNull(InscripcionesBLL.GetList(t => true));
        }

        [TestMethod()]
        public void Modificar()
        {

            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 1;
            
            Inscripciones inscripciones = new Inscripciones();
            inscripciones.InscripcionesId = 1;
            inscripciones.Monto = 102;
            inscripciones.FechaInscripcion = DateTime.Now;
            Assert.IsTrue(InscripcionesBLL.Modificar(inscripciones));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Estudiantes estudiantes = new Estudiantes();
            Assert.IsTrue(repositorioBaseBLL.Eliminar(1));
        }

        [TestMethod()]
        public void Eliminar2()
        {
            Inscripciones inscripciones = new Inscripciones();
            Assert.IsTrue(InscripcionesBLL.Eliminar(1));
        }
    }
}