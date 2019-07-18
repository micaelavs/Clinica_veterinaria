using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMvc.Models;

namespace WebAppMvc.Data
{
    public class RepositoryTurno : IRepository<Turno>
    {
        public void Delete(int id)
        {
            var db = new VetDbContext();
            Turno turno = db.Turnos.Find(id);
            db.Turnos.Remove(turno);
            db.SaveChanges();

        }

        public Turno GetById(int id)
        {
            var db = new VetDbContext();
            return db.Turnos.Find(id);

        }

        public void Insert(Turno entity)
        {
            var db = new VetDbContext();
            db.Turnos.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Turno> List()
        {

            var db = new VetDbContext();
            var turnos = db.Turnos.ToList();
            return turnos;


        }

        public void Update(Turno entity)
        {
            var db = new VetDbContext();
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}