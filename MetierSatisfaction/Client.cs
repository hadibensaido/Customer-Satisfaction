using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Client
    {
        // Primary key 
        int idClient { get; set; }
        string nomClient { get; set; }

        // Foreign key 
        public int idSegment { get; set; }

        // Navigation properties 
        public virtual Segment Segment { get; set; }


        // Foreign key 
        public int idInvitation { get; set; }

        // Navigation properties 
        public virtual Invitation Invitation { get; set; }

    }
}