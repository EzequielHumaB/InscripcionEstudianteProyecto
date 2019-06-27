using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.BLL;
using EstudianteInscripcionProyecto.DAL;

namespace TestsGenericos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Guardar()
        {
            Inscripciones inscripciones = new Inscripciones();
            inscripciones.InscripcionesId = 1;
            inscripciones.FechaInscripcion = DateTime.Now;
            inscripciones.DetalleInscripciones = new System.Collections.Generic.List<DetalleInscripciones>();
            inscripciones.Monto = 0;
            Assert.IsTrue(InscripcionesBLL.Guardar(inscripciones));

        }
    }
}
