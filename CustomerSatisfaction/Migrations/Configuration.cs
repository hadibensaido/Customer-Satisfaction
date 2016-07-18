namespace CustomerSatisfaction.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerSatisfaction.DAL.DbSatisfaction>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CustomerSatisfaction.DAL.DbSatisfaction context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /*
             
             context.Teachers.AddOrUpdate(t => t.Id,
                new AstonEcole.Metier.Teacher { Id = 1, Name = "Alain" },
                new AstonEcole.Metier.Teacher { Id = 2, Name = "Carla" },
                new AstonEcole.Metier.Teacher { Id = 3, Name = "Jean-Pierre" }
                );
             */

           DateTime date1 = DateTime.Parse("05/27/2016", System.Globalization.CultureInfo.InvariantCulture);
           DateTime date2 = DateTime.Parse("06/21/2016", System.Globalization.CultureInfo.InvariantCulture);
           DateTime date3 = DateTime.Parse("07/23/2016", System.Globalization.CultureInfo.InvariantCulture);
            MetierSatisfaction.Models.Invitation invit_1 = new MetierSatisfaction.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1 };
           MetierSatisfaction.Models.Invitation invit_2 = new MetierSatisfaction.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2 };
           MetierSatisfaction.Models.Invitation invit_3 =  new MetierSatisfaction.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3 };
           context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);


            context.SousSegment.AddOrUpdate(s => s.idSSegment,
               new MetierSatisfaction.Models.SousSegment { idSSegment = 1, idSegment = 1, libelleSSegment = "sous segment1" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 2, idSegment = 1, libelleSSegment = "sous segment2" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 3, idSegment = 1, libelleSSegment = "sous segment3" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 4, idSegment = 2, libelleSSegment = "sous segment4" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 5, idSegment = 2, libelleSSegment = "sous segment5" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 6, idSegment = 3, libelleSSegment = "sous segment6" },
               new MetierSatisfaction.Models.SousSegment { idSSegment = 7, idSegment = 3, libelleSSegment = "sous segment7" }
                );


            MetierSatisfaction.Models.Segment s1 = new MetierSatisfaction.Models.Segment { idSegment = 1, libelleSegment = "Busines" };
            List<MetierSatisfaction.Models.SousSegment> ss1 = new List<MetierSatisfaction.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(1));
            ss1.Add(context.SousSegment.Find(2));
            ss1.Add(context.SousSegment.Find(3));
            MetierSatisfaction.Models.Segment s2 = new MetierSatisfaction.Models.Segment { idSegment = 2, libelleSegment = "Social" };
            List<MetierSatisfaction.Models.SousSegment> ss2 = new List<MetierSatisfaction.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(4));
            ss1.Add(context.SousSegment.Find(5));
            MetierSatisfaction.Models.Segment s3 = new MetierSatisfaction.Models.Segment { idSegment = 3, libelleSegment = "Côte" };
            List<MetierSatisfaction.Models.SousSegment> ss3 = new List<MetierSatisfaction.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(6));
            ss1.Add(context.SousSegment.Find(7));
            context.Segment.AddOrUpdate(s => s.idSegment, s1, s2, s3);

            context.SaveChanges();
/*
            context.Client.AddOrUpdate(c => c.idClient,
               new MetierSatisfaction.Models.Client { idClient = 1, nomClient = "John_1", Segment= s1, Invitation = { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1 } },
               new MetierSatisfaction.Models.Client { idClient = 2, nomClient = "John_2", Segment = s2, Invitation = { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2 } },
               new MetierSatisfaction.Models.Client { idClient = 3, nomClient = "John_3", Segment = s3, Invitation = { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3 } }
               );

            /*
            context.Prestations.AddOrUpdate(
                new MetierSatisfaction.Models.Banquet {idPrestation = 1, datePrestation = date1, libelleBanquet ="Banquet_1"}
            );

            context.SaveChanges();
           
            

           
*/

        }
    }
}
