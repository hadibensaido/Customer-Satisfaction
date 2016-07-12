using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Segment
    {
        // Primary key 
        int idSegment { get; set; }

        string libelleSegment { get; set; }

        // Navigation property 
        public virtual ICollection<SousSegment> SSegments { get; set; }

        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }
    }
}