namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prestations",
                c => new
                    {
                        idPrestation = c.Int(nullable: false, identity: true),
                        datePrestation = c.DateTime(nullable: false),
                        idClient = c.Int(nullable: false),
                        idBanquet = c.Int(),
                        libelleBanquet = c.String(),
                        idPrestations = c.Int(),
                        idSejour = c.Int(),
                        libelleSejour = c.Int(),
                        idPrestations1 = c.Int(),
                        idSeminaire = c.Int(),
                        libelleSeminaire = c.String(),
                        idPrestations2 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idPrestation)
                .ForeignKey("dbo.Clients", t => t.idClient, cascadeDelete: true)
                .ForeignKey("dbo.Prestations", t => t.idPrestations)
                .ForeignKey("dbo.Prestations", t => t.idPrestations1)
                .ForeignKey("dbo.Prestations", t => t.idPrestations2)
                .Index(t => t.idClient)
                .Index(t => t.idPrestations)
                .Index(t => t.idPrestations1)
                .Index(t => t.idPrestations2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestations", "idPrestations2", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idPrestations1", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idPrestations", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idClient", "dbo.Clients");
            DropIndex("dbo.Prestations", new[] { "idPrestations2" });
            DropIndex("dbo.Prestations", new[] { "idPrestations1" });
            DropIndex("dbo.Prestations", new[] { "idPrestations" });
            DropIndex("dbo.Prestations", new[] { "idClient" });
            DropTable("dbo.Prestations");
        }
    }
}
