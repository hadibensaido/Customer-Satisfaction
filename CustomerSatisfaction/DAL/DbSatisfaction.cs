using CustomerSatisfaction.Models;
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

        public DbSet<Questionnaire> Questionnaire { get; set; }
        public DbSet<Etablissement> Etablissement { get; set; }

        public DbSet<Client> Client { get; set; }
        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Reponse> Reponse { get; set; }



    }



}