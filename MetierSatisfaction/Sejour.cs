using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Sejour:Prestations
    {
        public int idSejour { get; set; }
        public int libelleSejour { get; set; }
    }
}