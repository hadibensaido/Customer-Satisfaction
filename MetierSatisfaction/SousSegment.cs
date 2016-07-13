using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class SousSegment
    {
        // Primary key 
        [Key]
        public int idSSegment { get; set; }

        [Required]
        [StringLength(30)]
        public string libelleSSegment { get; set; }

        // Foreign key 
        [ForeignKey("Segment")]
        public int idSegment { get; set; }

        // Navigation properties 
        public virtual Segment Segment { get; set; }
    }
}