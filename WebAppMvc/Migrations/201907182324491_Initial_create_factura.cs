namespace WebAppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_create_factura : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdTurno = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Monto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turnoes", t => t.IdTurno, cascadeDelete: true)
                .Index(t => t.IdTurno);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facturas", "IdTurno", "dbo.Turnoes");
            DropIndex("dbo.Facturas", new[] { "IdTurno" });
            DropTable("dbo.Facturas");
        }
    }
}
