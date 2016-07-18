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
        public int idPrestation { get; set; }
        public DateTime datePrestation { get; set; }

    }
}