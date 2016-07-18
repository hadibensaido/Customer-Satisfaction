namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prestations",
                c => new
                    {
                        idPrestation = c.Int(nullable: false, identity: true),
                        datePrestation = c.DateTime(nullable: false),
                        idBanquet = c.Int(),
                        libelleBanquet = c.String(maxLength: 30),
                        idSejour = c.Int(),
                        libelleSejour = c.String(maxLength: 30),
                        idSeminaire = c.Int(),
                        libelleSeminaire = c.String(maxLength: 30),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Prestations_idPrestation = c.Int(),
                        Prestations_idPrestation1 = c.Int(),
                        Prestations_idPrestation2 = c.Int(),
                        Client_idClient = c.Int(),
                    })
                .PrimaryKey(t => t.idPrestation)
                .ForeignKey("dbo.Prestations", t => t.Prestations_idPrestation)
                .ForeignKey("dbo.Prestations", t => t.Prestations_idPrestation1)
                .ForeignKey("dbo.Prestations", t => t.Prestations_idPrestation2)
                .ForeignKey("dbo.Clients", t => t.Client_idClient)
                .Index(t => t.Prestations_idPrestation)
                .Index(t => t.Prestations_idPrestation1)
                .Index(t => t.Prestations_idPrestation2)
                .Index(t => t.Client_idClient);
            
            AddColumn("dbo.Clients", "idPrestation", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestations", "Client_idClient", "dbo.Clients");
            DropForeignKey("dbo.Prestations", "Prestations_idPrestation2", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "Prestations_idPrestation1", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "Prestations_idPrestation", "dbo.Prestations");
            DropIndex("dbo.Prestations", new[] { "Client_idClient" });
            DropIndex("dbo.Prestations", new[] { "Prestations_idPrestation2" });
            DropIndex("dbo.Prestations", new[] { "Prestations_idPrestation1" });
            DropIndex("dbo.Prestations", new[] { "Prestations_idPrestation" });
            DropColumn("dbo.Clients", "idPrestation");
            DropTable("dbo.Prestations");
        }
    }
}
