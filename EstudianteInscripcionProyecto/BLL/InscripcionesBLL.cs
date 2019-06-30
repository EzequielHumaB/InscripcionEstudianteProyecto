using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.DAL;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;

namespace EstudianteInscripcionProyecto.BLL
{
   public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Estudiantes estudiantes = new Estudiantes();
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {     
                if(contexto.Inscripciones.Add(inscripciones)!=null)
                {
                //    var buscarEstudiante = repositorioBaseBLL.Buscar(inscripciones.EstudianteId);
                  //  inscripciones.CalcularMonto();
                  //  estudiantes.Balance = inscripciones.Monto;
                    paso = contexto.SaveChanges() > 0;
                    //repositorioBaseBLL.Modificar(buscarEstudiante);
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
                var Inscripcion = contexto.Inscripciones.Find(id);
                var estudiante = E.Buscar(Inscripcion.EstudianteId);
                estudiante.Balance = estudiante.Balance - Inscripcion.MontoInscripcion;
                Est.Modificar(estudiante);
                db.Entry(Inscripcion).State = EntityState.Deleted;
             

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
           RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
           try
           {
              var estudiante = repositorioBaseBLL.Buscar(inscripciones.EstudianteId);
              var anterior = new RepositorioBaseBLL<Inscripciones>().Buscar(inscripciones.InscripcionesId);
              estudiante.Balance = anterior.Monto;
              foreach(var item in anterior.DetalleInscripciones)
              {
                  if(!inscripciones.DetalleInscripciones.Any(A =>A.DetalleInscripcionId == item.DetalleInscripcionId))
                  {
                      contexto.Entry(item).State = EntityState.Deleted;
                  }
              }
              foreach (var item in inscripciones.DetalleInscripciones)
              {
                 if(item.DetalleInscripcionId==0)
              {
                 contexto.Entry(item).State = EntityState.Added;
              }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                    
                }
                contexto.Entry(inscripciones).State = EntityState.Modified;
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
