using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudianteInscripcionProyecto.Entidades
{
    public class DetalleInscripciones
    {

        [Key]
        public int DetalleInscripcionId { get; set; }
        public int InscripcionesId { get; set; }
        public decimal MontoDetalle { get; set; }

        public int EstudianteId { get; set; }

        public decimal Balance { get; set; }
        
        public int AsignaturaId { get;  set; }

        public int Creditos { get; set; }

        public DetalleInscripciones()
        {
            DetalleInscripcionId = 0;
            EstudianteId = 0;
            MontoDetalle = 0;
            AsignaturaId = 0;
        }

        public DetalleInscripciones(int DetalleInscripcionId, int EstudianteId, decimal MontoDetalle,int creditos)
        {
            this.DetalleInscripcionId = DetalleInscripcionId;
            this.EstudianteId = EstudianteId;
            this.MontoDetalle = MontoDetalle;
            Creditos = creditos;
        }
    }
}