using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EstudianteInscripcionProyecto.Entidades
{
   public class Inscripciones
    {
        [Key]
        public int InscripcionesId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public decimal Monto { get; set; }
        public Inscripciones()
        {
            this.InscripcionesId = 0;
            FechaInscripcion = DateTime.Now;
            Monto = 0;
        }

    }
}
