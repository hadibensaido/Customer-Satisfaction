namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Prestations", name: "idPrestations", newName: "Prestations_idPrestation");
            RenameColumn(table: "dbo.Prestations", name: "idPrestations1", newName: "Prestations_idPrestation1");
            RenameColumn(table: "dbo.Prestations", name: "idPrestations2", newName: "Prestations_idPrestation2");
            RenameIndex(table: "dbo.Prestations", name: "IX_idPrestations", newName: "IX_Prestations_idPrestation");
            RenameIndex(table: "dbo.Prestations", name: "IX_idPrestations1", newName: "IX_Prestations_idPrestation1");
            RenameIndex(table: "dbo.Prestations", name: "IX_idPrestations2", newName: "IX_Prestations_idPrestation2");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Prestations", name: "IX_Prestations_idPrestation2", newName: "IX_idPrestations2");
            RenameIndex(table: "dbo.Prestations", name: "IX_Prestations_idPrestation1", newName: "IX_idPrestations1");
            RenameIndex(table: "dbo.Prestations", name: "IX_Prestations_idPrestation", newName: "IX_idPrestations");
            RenameColumn(table: "dbo.Prestations", name: "Prestations_idPrestation2", newName: "idPrestations2");
            RenameColumn(table: "dbo.Prestations", name: "Prestations_idPrestation1", newName: "idPrestations1");
            RenameColumn(table: "dbo.Prestations", name: "Prestations_idPrestation", newName: "idPrestations");
        }
    }
}
