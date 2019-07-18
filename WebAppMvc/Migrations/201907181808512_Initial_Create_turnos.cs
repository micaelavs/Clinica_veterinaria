namespace WebAppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create_turnos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPaciente = c.Int(nullable: false),
                        IdSala = c.Int(nullable: false),
                        IdDoctor = c.Int(nullable: false),
                        TipoEspecialidad = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.IdDoctor, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.IdPaciente, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.IdSala, cascadeDelete: true)
                .Index(t => t.IdPaciente)
                .Index(t => t.IdSala)
                .Index(t => t.IdDoctor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "IdSala", "dbo.Rooms");
            DropForeignKey("dbo.Turnoes", "IdPaciente", "dbo.Patients");
            DropForeignKey("dbo.Turnoes", "IdDoctor", "dbo.Doctors");
            DropIndex("dbo.Turnoes", new[] { "IdDoctor" });
            DropIndex("dbo.Turnoes", new[] { "IdSala" });
            DropIndex("dbo.Turnoes", new[] { "IdPaciente" });
            DropTable("dbo.Turnoes");
        }
    }
}
