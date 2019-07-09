using ClientPatientManagement.Core.Interfaces;
using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvc.Data
{
    public class RepositoryRoom : IRepository<Room>
    {

        public void Delete(int id)
        {
            var db = new VetDbContext();
            Room room = db.Rooms.Find(id);
            db.Rooms.Remove(room);
            db.SaveChanges();
        }

        public Room GetById(int id)
        {
            var db = new VetDbContext();
            return db.Rooms.Find(id);
        }

        public void Insert(Room entity)
        {
            var db = new VetDbContext();
            db.Rooms.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Room> List()
        {

            //var rooms = new List<Room>();
            //var room = new Room();
            //room.Id = 1;
            //room.Name = "Sala 1";
            //room.Location = "Norte";
            //rooms.Add(room);

            //room = new Room();
            //room.Id = 2;
            //room.Name = "Sala 2";
            //room.Location = "Oeste";
            //rooms.Add(room);

            //room = new Room();
            //room.Id = 3;
            //room.Name = "Sala 3";
            //room.Location = "Sur";
            //rooms.Add(room);
            var db = new VetDbContext();
            var rooms = db.Rooms.ToList();
            return rooms;


        }

        public void Update(Room entity)
        {
            var db = new VetDbContext();
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}