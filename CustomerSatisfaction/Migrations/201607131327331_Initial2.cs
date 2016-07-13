namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        idAudit = c.Int(nullable: false, identity: true),
                        dateAudit = c.DateTime(nullable: false),
                        libelleAudit = c.String(),
                        idEtablissement = c.Int(nullable: false),
                        idQuestionnaire = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idAudit)
                .ForeignKey("dbo.Etablissements", t => t.idEtablissement, cascadeDelete: true)
                .ForeignKey("dbo.Questionnaires", t => t.idQuestionnaire, cascadeDelete: true)
                .Index(t => t.idEtablissement)
                .Index(t => t.idQuestionnaire);
            
            CreateTable(
                "dbo.Etablissements",
                c => new
                    {
                        idEtablissement = c.Int(nullable: false, identity: true),
                        libelleEtablissement = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idEtablissement);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        idUtilisateur = c.Int(nullable: false, identity: true),
                        nomUtilisateur = c.String(nullable: false, maxLength: 50),
                        Etablissement_idEtablissement = c.Int(),
                    })
                .PrimaryKey(t => t.idUtilisateur)
                .ForeignKey("dbo.Etablissements", t => t.Etablissement_idEtablissement)
                .Index(t => t.Etablissement_idEtablissement);
            
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        idQuestionnaire = c.Int(nullable: false, identity: true),
                        libelleQuestionnaire = c.String(),
                        idType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idQuestionnaire)
                .ForeignKey("dbo.TypeQuestionnaires", t => t.idType, cascadeDelete: true)
                .Index(t => t.idType);
            
            CreateTable(
                "dbo.TypeQuestionnaires",
                c => new
                    {
                        idType = c.Int(nullable: false, identity: true),
                        libelleType = c.String(),
                    })
                .PrimaryKey(t => t.idType);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        idQuestion = c.Int(nullable: false, identity: true),
                        libelleQuestion = c.String(),
                    })
                .PrimaryKey(t => t.idQuestion);
            
            CreateTable(
                "dbo.Reponses",
                c => new
                    {
                        idReponse = c.Int(nullable: false, identity: true),
                        reponse = c.String(),
                        commentaire = c.String(),
                        idQuestion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idReponse)
                .ForeignKey("dbo.Questions", t => t.idQuestion, cascadeDelete: true)
                .Index(t => t.idQuestion);
            
            AddColumn("dbo.Clients", "Etablissement_idEtablissement", c => c.Int());
            CreateIndex("dbo.Clients", "Etablissement_idEtablissement");
            AddForeignKey("dbo.Clients", "Etablissement_idEtablissement", "dbo.Etablissements", "idEtablissement");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reponses", "idQuestion", "dbo.Questions");
            DropForeignKey("dbo.Audits", "idQuestionnaire", "dbo.Questionnaires");
            DropForeignKey("dbo.Questionnaires", "idType", "dbo.TypeQuestionnaires");
            DropForeignKey("dbo.Audits", "idEtablissement", "dbo.Etablissements");
            DropForeignKey("dbo.Utilisateurs", "Etablissement_idEtablissement", "dbo.Etablissements");
            DropForeignKey("dbo.Clients", "Etablissement_idEtablissement", "dbo.Etablissements");
            DropIndex("dbo.Reponses", new[] { "idQuestion" });
            DropIndex("dbo.Questionnaires", new[] { "idType" });
            DropIndex("dbo.Utilisateurs", new[] { "Etablissement_idEtablissement" });
            DropIndex("dbo.Clients", new[] { "Etablissement_idEtablissement" });
            DropIndex("dbo.Audits", new[] { "idQuestionnaire" });
            DropIndex("dbo.Audits", new[] { "idEtablissement" });
            DropColumn("dbo.Clients", "Etablissement_idEtablissement");
            DropTable("dbo.Reponses");
            DropTable("dbo.Questions");
            DropTable("dbo.TypeQuestionnaires");
            DropTable("dbo.Questionnaires");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Etablissements");
            DropTable("dbo.Audits");
        }
    }
}
