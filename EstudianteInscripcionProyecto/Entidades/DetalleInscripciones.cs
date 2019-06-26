using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EstudianteInscripcionProyecto.Entidades
{
   public class DetalleInscripciones
    {
        [Key]
        public int DetalleInscripcionId { get; set; }
        public int InscripcionId { get; set; }
        public decimal Monto { get; set; }
        public DetalleInscripciones()
        {
            DetalleInscripcionId = 0;
            InscripcionId = 0;
            Monto = 0;
        }

        public DetalleInscripciones(int InscripcionDetalleId, int Idinscripcion, decimal totalMonto)
        {
            DetalleInscripcionId = InscripcionDetalleId;
            InscripcionId = Idinscripcion;
            Monto = totalMonto;
        }
    }
}
