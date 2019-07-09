using ClientPatientManagement.Core.Interfaces;
using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvc.Data
{
    public class RepositoryDoctor : IRepository<Doctor>
    {
        public void Delete(int id)
        {
            var db = new VetDbContext();
            Doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
            db.SaveChanges();

        }

        public Doctor GetById(int id)
        {
            var db = new VetDbContext();
            return db.Doctors.Find(id);

        }

        public void Insert(Doctor entity)
        {
            var db = new VetDbContext();
            db.Doctors.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Doctor> List()
        {

            var db = new VetDbContext();
            var doctors = db.Doctors.ToList();
            return doctors;


        }

        public void Update(Doctor entity)
        {
            var db = new VetDbContext();
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}