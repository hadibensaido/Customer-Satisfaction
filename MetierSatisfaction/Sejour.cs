using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Sejour:Prestations
    {
        [Key]
        public int idSejour { get; set; }
        public int libelleSejour { get; set; }

        [ForeignKey("Prestations")]
        public virtual int idPrestations { get; set; }

        public virtual Prestations Prestations { get; set; }
    }
}