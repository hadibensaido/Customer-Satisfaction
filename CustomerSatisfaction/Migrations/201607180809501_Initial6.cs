namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prestations", "idPrestations", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idPrestations1", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idPrestations2", "dbo.Prestations");
            DropForeignKey("dbo.Prestations", "idClient", "dbo.Clients");
            DropIndex("dbo.Prestations", new[] { "idClient" });
            DropIndex("dbo.Prestations", new[] { "idPrestations" });
            DropIndex("dbo.Prestations", new[] { "idPrestations1" });
            DropIndex("dbo.Prestations", new[] { "idPrestations2" });
            RenameColumn(table: "dbo.Prestations", name: "idClient", newName: "Client_idClient");
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        idCompte = c.Int(nullable: false, identity: true),
                        libelleCompte = c.String(nullable: false, maxLength: 50),
                        profil_idProfil = c.Int(),
                    })
                .PrimaryKey(t => t.idCompte)
                .ForeignKey("dbo.Profils", t => t.profil_idProfil)
                .Index(t => t.profil_idProfil);
            
            CreateTable(
                "dbo.Profils",
                c => new
                    {
                        idProfil = c.Int(nullable: false, identity: true),
                        libelleProfil = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idProfil);
            
            AddColumn("dbo.Etablissements", "Compte_idCompte", c => c.Int());
            AlterColumn("dbo.Prestations", "Client_idClient", c => c.Int());
            CreateIndex("dbo.Etablissements", "Compte_idCompte");
            CreateIndex("dbo.Prestations", "Client_idClient");
            AddForeignKey("dbo.Etablissements", "Compte_idCompte", "dbo.Comptes", "idCompte");
            AddForeignKey("dbo.Prestations", "Client_idClient", "dbo.Clients", "idClient");
            DropColumn("dbo.Prestations", "idBanquet");
            DropColumn("dbo.Prestations", "idPrestations");
            DropColumn("dbo.Prestations", "idSejour");
            DropColumn("dbo.Prestations", "idPrestations1");
            DropColumn("dbo.Prestations", "idSeminaire");
            DropColumn("dbo.Prestations", "idPrestations2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prestations", "idPrestations2", c => c.Int());
            AddColumn("dbo.Prestations", "idSeminaire", c => c.Int());
            AddColumn("dbo.Prestations", "idPrestations1", c => c.Int());
            AddColumn("dbo.Prestations", "idSejour", c => c.Int());
            AddColumn("dbo.Prestations", "idPrestations", c => c.Int());
            AddColumn("dbo.Prestations", "idBanquet", c => c.Int());
            DropForeignKey("dbo.Prestations", "Client_idClient", "dbo.Clients");
            DropForeignKey("dbo.Comptes", "profil_idProfil", "dbo.Profils");
            DropForeignKey("dbo.Etablissements", "Compte_idCompte", "dbo.Comptes");
            DropIndex("dbo.Comptes", new[] { "profil_idProfil" });
            DropIndex("dbo.Prestations", new[] { "Client_idClient" });
            DropIndex("dbo.Etablissements", new[] { "Compte_idCompte" });
            AlterColumn("dbo.Prestations", "Client_idClient", c => c.Int(nullable: false));
            DropColumn("dbo.Etablissements", "Compte_idCompte");
            DropTable("dbo.Profils");
            DropTable("dbo.Comptes");
            RenameColumn(table: "dbo.Prestations", name: "Client_idClient", newName: "idClient");
            CreateIndex("dbo.Prestations", "idPrestations2");
            CreateIndex("dbo.Prestations", "idPrestations1");
            CreateIndex("dbo.Prestations", "idPrestations");
            CreateIndex("dbo.Prestations", "idClient");
            AddForeignKey("dbo.Prestations", "idClient", "dbo.Clients", "idClient", cascadeDelete: true);
            AddForeignKey("dbo.Prestations", "idPrestations2", "dbo.Prestations", "idPrestation");
            AddForeignKey("dbo.Prestations", "idPrestations1", "dbo.Prestations", "idPrestation");
            AddForeignKey("dbo.Prestations", "idPrestations", "dbo.Prestations", "idPrestation");
        }
    }
}
