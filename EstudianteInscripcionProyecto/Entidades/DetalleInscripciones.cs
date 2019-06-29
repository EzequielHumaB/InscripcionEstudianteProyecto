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
        public int InscripcionId { get; set; }
        public decimal Monto { get; set; }

        public int EstudianteId { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual Estudiantes Estudiantes {get;set;}
        public decimal Balance { get; set; }

        
        public DetalleInscripciones()
        {
            DetalleInscripcionId = 0;
            InscripcionId = 0;
            Monto = 0;
            EstudianteId = 0;
            Estudiantes = new Estudiantes();
            Balance = 0;
        }

        public DetalleInscripciones(int InscripcionDetalleId,int IdEstudiante,Estudiantes estudiantes , decimal balance)
        {
            DetalleInscripcionId = InscripcionDetalleId;
            EstudianteId = IdEstudiante;
            Estudiantes = estudiantes;
            Balance = balance;
        }
    }
}
