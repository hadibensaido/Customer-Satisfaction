using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Banquet:Prestations
    {
        [Key]
        public int idBanquet { get; set; }
        public string libelleBanquet { get; set; }
    }
}