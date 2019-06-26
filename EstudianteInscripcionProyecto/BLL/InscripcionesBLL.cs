using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.DAL;

namespace EstudianteInscripcionProyecto.BLL
{
   public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Inscripciones.Add(inscripciones)!=null)
                {
                    foreach(var item in inscripciones.DetalleInscripciones)
                    {
                        contexto.Estudiantes.Find(item.EstudianteId).Balance = item.Monto;
                    }

                    paso = contexto.SaveChanges() > 0;
                }

            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Inscripciones inscripciones = new Inscripciones();
            Contexto contexto = new Contexto(); 
            try
            {
                foreach(var item in inscripciones.DetalleInscripciones)
                {
                   var eliminar = contexto.Estudiantes.Find(item.EstudianteId);
                   contexto.Entry(eliminar).State = EntityState.Deleted;
                   contexto.Entry(item).State = EntityState.Deleted;
                }
               
                paso = contexto.SaveChanges() > 0;
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
               
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
  
    }
}
