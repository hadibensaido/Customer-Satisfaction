﻿using CustomerSatisfaction.Models;
using MetierSatisfaction.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace CustomerSatisfaction.DAL
{
    public class DbSatisfaction : IdentityDbContext<ApplicationUser>
    {

       
        public DbSet<Client> Client { get; set; }
        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<Segment> Segment { get; set; }
        public DbSet<SousSegment> SousSegment { get; set; }
        public DbSet<Questionnaire> Questionnaire { get; set; }
        public DbSet<Etablissement> Etablissement { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Reponse> Reponse { get; set; }
        public DbSet<Audit> Audit { get; set; }
        public DbSet<TypeQuestionnaire> TypeQuestionnaire { get; set; }
        public DbSet<Prestations> Prestations { get; set; }
        public DbSet<Banquet> Banquet { get; set; }
        public DbSet<Compte> Compte { get; set; }
        public DbSet<Seminaire> Seminaire { get; set; }
        public DbSet<Sejour> Sejour { get; set; }


        #region Constructeurs
        public DbSatisfaction() : base("DbSatisfaction") { }
        #endregion
    }



}