using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data.Entity;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.DAL;

namespace EstudianteInscripcionProyecto.BLL
{
   public class AsignaturasBLL
    {
        public static bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Asignaturas.Add(asignaturas)!=null)
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
      
        public static bool Modificar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(asignaturas).State = EntityState.Modified;
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
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Asignaturas.Find(id);
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

        public static Asignaturas Buscar(int id)
        {
            Asignaturas asignaturas = new Asignaturas();
            Contexto contexto = new Contexto();
            try
            {
                asignaturas = contexto.Asignaturas.Find(id);
            }catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return asignaturas;
        }

        public static List<Asignaturas> GetList(Expression<Func<Asignaturas,bool>>expression)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Asignaturas.Where(expression).ToList();
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
