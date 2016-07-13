using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Seminaire:Prestations
    {
        [Key]
        public int idSeminaire { get; set; }
        public string libelleSeminaire { get; set; }

        [ForeignKey("Prestations")]
        public virtual int idPrestations { get; set; }

        public virtual Prestations Prestations { get; set; }
    }
}