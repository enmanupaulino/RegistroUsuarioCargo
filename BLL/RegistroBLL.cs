using Registro.DAL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registro.BLL
{
    public class RegistroBLL
    {
        public static bool Guardar(Usuarios usuario) {
            bool paso = true;
            Contexto db = new Contexto();
            try {
                if (db.usuario.Add(usuario) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
       }
        public  static bool Modificar (Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(usuario).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                    }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return paso;
        }
        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.usuario.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return paso;
            }
        public static  Usuarios Buscar (int Id)
        {
            

            Contexto db = new Contexto();
            Usuarios Usuario = new Usuarios();
            try
            {
                Usuario = db.usuario.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return Usuario;
        }
        public static List<Usuarios>GetList(Expression<Func<Usuarios, bool>> usuario)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.usuario.Where(usuario).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
