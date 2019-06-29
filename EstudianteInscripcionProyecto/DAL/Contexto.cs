using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EstudianteInscripcionProyecto.Entidades;

namespace EstudianteInscripcionProyecto.DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }

        public Contexto() : base("ConStr")
        {
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
        }
        
    }
}
