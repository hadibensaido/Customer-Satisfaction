using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Client
    {
        // Primary key 
        [Key]
        public int idClient { get; set; }

        [Required]
        [StringLength(30)]
        public string nomClient { get; set; }

        // Foreign key 
        [ForeignKey("Segment")]
        public int idSegment { get; set; }

        // Navigation properties 
        public virtual Segment Segment { get; set; }


        // Foreign key 
        [ForeignKey("Invitation")]
        public int idInvitation { get; set; }

        // Navigation properties 
        public virtual Invitation Invitation { get; set; }

        // les prestations du client

        public virtual ICollection<Prestations> Prestations { get; set; }

    }
}