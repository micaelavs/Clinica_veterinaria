using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMvc.Models;

namespace WebAppMvc.Data
{
    public class FacturaData
    {

        public class RepositoryFactura : IRepository<Factura>
        {

            public void Delete(int id)
            {
                var db = new VetDbContext();
                Factura factura = db.Facturas.Find(id);
                db.Facturas.Remove(factura);
                db.SaveChanges();
            }

            public Factura GetById(int id)
            {
                var db = new VetDbContext();
                return db.Facturas.Find(id);
            }

            public void Insert(Factura entity)
            {
                var db = new VetDbContext();
                db.Facturas.Add(entity);
                db.SaveChanges();
            }

            public IEnumerable<Factura> List()
            {

                var db = new VetDbContext();
                var facturas = db.Facturas.ToList();
                return facturas;


            }

            public void Update(Factura entity)
            {
                var db = new VetDbContext();
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}