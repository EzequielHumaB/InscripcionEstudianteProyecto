using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using EstudianteInscripcionProyecto.DAL;
using System.Data.Entity;
using EstudianteInscripcionProyecto;

namespace EstudianteInscripcionProyecto.BLL
{
    public class RepositorioBaseBLL<T> : IDisposable, IInterfazBLL<T> where T : class
    {
        internal Contexto _contexto;

        public RepositorioBaseBLL()
        {
            _contexto = new Contexto();
        }
        
        public virtual bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity)!=null)
                {
                    paso = _contexto.SaveChanges() > 0;
                }
            }catch
            {
                throw;
            }
          
            return paso;
        }

        public virtual bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
                paso = _contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
           
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            bool paso = false;
            try
            {

                _contexto.Entry(entity).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }catch
            {
                throw;
            }
       
            return paso;
        }

        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }catch
            {
                throw;
            }
            
            return entity;
        }

        public List<T> GetList(Expression<Func<T,bool>> expression)
        {
            List<T> lista = new List<T>();
            try
            {
                lista = _contexto.Set<T>().Where(expression).ToList();
            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return lista;
        }
       

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
