using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMvc.Models;

namespace WebAppMvc.Data
{
    public class VetDbContext : DbContext
    {
        public VetDbContext() :
            base("DefaultConnection")
        {

        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}