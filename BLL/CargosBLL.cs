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
    public class CargosBLL
    {
        public static bool Guardar(Cargos cargo)
        {
            bool paso = true;
            Contexto db = new Contexto();
            try
            {
                if (db.cargo.Add(cargo) != null)
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
        public static bool Modificar(Cargos cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(cargo).State = EntityState.Modified;
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
        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.cargo.Find(Id);
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
        public static Cargos Buscar(int Id)
        {
            Contexto db = new Contexto();
            Cargos Cargos = new Cargos();
            try
            {
                Cargos = db.cargo.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return Cargos;
        }
        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> cargo)
        {
            List<Cargos> Lista = new List<Cargos>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.cargo.Where(cargo).ToList();
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
