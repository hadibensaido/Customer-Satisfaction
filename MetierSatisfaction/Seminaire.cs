using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Seminaire:Prestations
    {
        public int idSeminaire { get; set; }
        public string libelleSeminaire { get; set; }
    }
}