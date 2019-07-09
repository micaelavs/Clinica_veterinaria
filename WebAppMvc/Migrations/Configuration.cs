namespace WebAppMvc.Migrations
{
    using ClientPatientManagement.Core.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppMvc.Data.VetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppMvc.Data.VetDbContext context)
        {
            /*rooms*/
            /*  IList<Room> rooms = new List<Room>();

              rooms.Add(new Room()
              {
                  Name = "Room 1",
                  Location = "Oeste"
              });
              rooms.Add(new Room()
              {
                  Name = "Room 2",
                  Location = "JCP"
              });
              foreach (Room room in rooms)
              {
                  context.Rooms.Add(room);
                  base.Seed(context);
              }*/

            /******doctor******/

            /* IList<Doctor> doctors = new List<Doctor>();

             doctors.Add(new Doctor()
             {   
                 Name = "juan",
                 Email = "juan@hotmail.com"
             });
             doctors.Add(new Doctor()
             {
                 Name = "Ignacio",
                 Email = "ignacio@gmail.com"
             });
             foreach (Doctor doctor in doctors)
             {
                 context.Doctors.Add(doctor);
                 base.Seed(context);
             }
             */
            /*****Client******/
           /* IList<Client> clients = new List<Client>();

            clients.Add(new Client()
            {
                FullName = "Ignacio Gómez",
                Email = "ignacio@hotmail.com"
            });
            clients.Add(new Client()
            {
                FullName = "Horario Sanchez",
                Email = "ignacio@gmail.com"
            });
            clients.Add(new Client()
            {
                FullName = "Camilo Perez",
                Email = "camilop@gmail.com"
            });

            foreach (Client client in clients)
            {
                context.Clients.Add(client);
                base.Seed(context);
            }*/
        }
    }
}
