using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Invitation
    {
        // Primary key 
        [Key]
        public  int idInvitation { get; set; }

        [Required]
        public DateTime dateEvoi { get; set; }

        [Required]
        [StringLength(30)]
        public String libelleInvitation { get; set; }

        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }
    }
}