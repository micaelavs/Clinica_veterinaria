using ClientPatientManagement.Core.Interfaces;
using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvc.Data
{
    public class RepositoryClient: IRepository<Client>
    {
        public void Delete(int id)
        {
            var db = new VetDbContext();
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
            db.SaveChanges();

        }

        public Client GetById(int id)
        {
            var db = new VetDbContext();
            return db.Clients.Find(id);

        }

        public void Insert(Client entity)
        {
            var db = new VetDbContext();
            db.Clients.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Client> List()
        {

            var db = new VetDbContext();
            var clients = db.Clients.ToList();
            return clients;


        }

        public void Update(Client entity)
        {
            var db = new VetDbContext();
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}