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

        public static bool Eliminar(int id)
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
                contexto.Dispose
            }
        }
    }
}
