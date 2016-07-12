using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Invitation
    {
        // Primary key 
        int idInvitation { get; set; }

        DateTime dateEvoi { get; set; }
        String libelleInvitation { get; set; }

        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }
    }
}