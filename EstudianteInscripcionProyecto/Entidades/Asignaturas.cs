using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EstudianteInscripcionProyecto.Entidades
{
  public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public short Creditos { get; set; } 
        //Lo puse short porque entiendo que un estudiante no va a tener mas 32000 creditos

        public Asignaturas()
        {
            AsignaturaId = 0;
            Descripcion = string.Empty;
            Creditos = 0;
        }
 
    }
}
