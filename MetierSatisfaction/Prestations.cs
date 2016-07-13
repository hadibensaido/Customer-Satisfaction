using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public abstract class Prestations
    {
        [Key]
        int idPrestation { get; set; }
        DateTime datePrestation { get; set; }

        // Foreign key 
        [ForeignKey("Client")]
        public int idClient { get; set; }

        // Navigation properties 
        public virtual Client Client { get; set; }
    }
}