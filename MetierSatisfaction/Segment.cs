using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Segment
    {
        // Primary key 
        [Key]
        public int idSegment { get; set; }

        [Required]
        [StringLength(30)]
        public string libelleSegment { get; set; }

        // Navigation property 
        public virtual ICollection<SousSegment> SSegments { get; set; }

        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }
    }
}