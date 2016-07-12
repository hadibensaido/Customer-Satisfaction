using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class SousSegment
    {
        // Primary key 
        int idSSegment { get; set; }

        string libelleSSegment { get; set; }

        // Foreign key 
        public int idSegment { get; set; }

        // Navigation properties 
        public virtual Segment Segment { get; set; }
    }
}