using ClientPatientManagement.Core.Interfaces;
using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvc.Data
{
    public class RepositoryPatient : IRepository<Patient>
    {
        public void Delete(int id)
        {
            var db = new VetDbContext();
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
            db.SaveChanges();

        }

        public Patient GetById(int id)
        {
            var db = new VetDbContext();
            return db.Patients.Find(id);

        }

        public void Insert(Patient entity)
        {
            var db = new VetDbContext();
            db.Patients.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Patient> List()
        {

            var db = new VetDbContext();
            var patients = db.Patients.ToList();
            return patients ;


        }

        public void Update(Patient entity)
        {
            var db = new VetDbContext();
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}