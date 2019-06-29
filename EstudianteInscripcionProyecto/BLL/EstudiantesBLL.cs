using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using EstudianteInscripcionProyecto.DAL;
using EstudianteInscripcionProyecto.Entidades;

namespace EstudianteInscripcionProyecto.BLL
{
   public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Estudiantes.Add(estudiantes)!=null)
                {
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

        public static bool Modificar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(estudiantes).State = System.Data.Entity.EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Estudiantes estudiantes = new Estudiantes();
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Estudiantes.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
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

        public static Estudiantes Buscar(int id)
        {
            Estudiantes estudiantes = new Estudiantes();
            Contexto contexto = new Contexto();
            try
            {
                estudiantes = contexto.Estudiantes.Find(id);
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return estudiantes;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes,bool>>expression)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Estudiantes.Where(expression).ToList();
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
    }
}
