﻿using CustomerSatisfaction.Models;
using MetierSatisfaction.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CustomerSatisfaction.DAL
{
    public class DbSatisfaction : IdentityDbContext<ApplicationUser>
    {
        public DbSatisfaction() : base("DefaultConnection") { }

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






    }



}