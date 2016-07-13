namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        idClient = c.Int(nullable: false, identity: true),
                        nomClient = c.String(nullable: false, maxLength: 30),
                        idSegment = c.Int(nullable: false),
                        idInvitation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idClient)
                .ForeignKey("dbo.Invitations", t => t.idInvitation, cascadeDelete: true)
                .ForeignKey("dbo.Segments", t => t.idSegment, cascadeDelete: true)
                .Index(t => t.idSegment)
                .Index(t => t.idInvitation);
            
            CreateTable(
                "dbo.Invitations",
                c => new
                    {
                        idInvitation = c.Int(nullable: false, identity: true),
                        dateEvoi = c.DateTime(nullable: false),
                        libelleInvitation = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.idInvitation);
            
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        idSegment = c.Int(nullable: false, identity: true),
                        libelleSegment = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.idSegment);
            
            CreateTable(
                "dbo.SousSegments",
                c => new
                    {
                        idSSegment = c.Int(nullable: false, identity: true),
                        libelleSSegment = c.String(nullable: false, maxLength: 30),
                        idSegment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSSegment)
                .ForeignKey("dbo.Segments", t => t.idSegment, cascadeDelete: true)
                .Index(t => t.idSegment);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "idSegment", "dbo.Segments");
            DropForeignKey("dbo.SousSegments", "idSegment", "dbo.Segments");
            DropForeignKey("dbo.Clients", "idInvitation", "dbo.Invitations");
            DropIndex("dbo.SousSegments", new[] { "idSegment" });
            DropIndex("dbo.Clients", new[] { "idInvitation" });
            DropIndex("dbo.Clients", new[] { "idSegment" });
            DropTable("dbo.SousSegments");
            DropTable("dbo.Segments");
            DropTable("dbo.Invitations");
            DropTable("dbo.Clients");
        }
    }
}
