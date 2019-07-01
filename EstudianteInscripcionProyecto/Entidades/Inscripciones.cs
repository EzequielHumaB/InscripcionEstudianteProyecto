using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudianteInscripcionProyecto.Entidades
{
   public class Inscripciones
    {
        Estudiantes estudiantes = new Estudiantes();
        Asignaturas asignaturas = new Asignaturas();
        [Key]
        public int InscripcionesId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public decimal Monto { get; set; }
        public int EstudianteId { get; set; }


        public virtual List<DetalleInscripciones> DetalleInscripciones { get; set; }
        public Inscripciones()
        {
            this.InscripcionesId = 0;
            FechaInscripcion = DateTime.Now;
            Monto = 0;
            EstudianteId = 0;
            DetalleInscripciones = new List<DetalleInscripciones>();
        }

        public void CalcularMonto()
        {
            decimal resultado = 0;
            foreach(var item in DetalleInscripciones)
            {
                resultado += (item.MontoDetalle*item.Creditos);
            }
            Monto = resultado;
        }

    }
}
