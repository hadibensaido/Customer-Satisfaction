using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Sejour:Prestations
    {
        [Key]
        public int idSejour { get; set; }
        public int libelleSejour { get; set; }
    }
}