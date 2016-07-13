using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Seminaire:Prestations
    {
        [Key]
        public int idSeminaire { get; set; }
        public string libelleSeminaire { get; set; }
    }
}