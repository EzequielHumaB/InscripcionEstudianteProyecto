using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.DAL;
using System.Linq.Expressions;

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
                        contexto.Estudiantes.Find(item.EstudianteId).Balance += inscripciones.Monto;
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
                var eliminarInscripcion = contexto.Inscripciones.Find(id);
                contexto.Entry(eliminarInscripcion).State = EntityState.Deleted;

              
                foreach(var item in inscripciones.DetalleInscripciones)
                {
                    contexto.Estudiantes.Find(item.EstudianteId).Balance = inscripciones.Monto; 
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

        public static Inscripciones Buscar(int id)
        {
            Inscripciones inscripciones = new Inscripciones();
            Contexto contexto = new Contexto();
            try
            {
                inscripciones = contexto.Inscripciones.Find(id);
                inscripciones.DetalleInscripciones.Count();
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return inscripciones;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones,bool>>expression)
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Inscripciones.Where(expression).ToList();
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(inscripciones).State = EntityState.Modified;
                foreach (var item in inscripciones.DetalleInscripciones)
                {
                    contexto.Estudiantes.Find(item.EstudianteId).Balance = inscripciones.Monto;
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
  
    }
}
