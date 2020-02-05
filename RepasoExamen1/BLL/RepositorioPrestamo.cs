using Microsoft.EntityFrameworkCore;
using RepasoExamen1.DAL;
using RepasoExamen1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepasoExamen1.BLL
{
    public class RepositorioPrestamo
    {
        internal Contexto db;

        public RepositorioPrestamo()
        {
            db = new Contexto();
        }

        public bool Guardar(Prestamos entity)
        {
            bool paso = false;


            try
            {
                if (db.Prestamos.Add(entity) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public bool Modificar(Prestamos entity)
        {
            bool paso = false;


            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public List<Prestamos> GetList(Expression<Func<Prestamos, bool>> expression)
        {
            List<Prestamos> lista = new List<Prestamos>();


            try
            {
                lista = db.Prestamos.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }


            return lista;

        }

    }
}
