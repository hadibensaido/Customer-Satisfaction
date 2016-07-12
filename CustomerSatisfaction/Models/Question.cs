using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Question:Prestations
    {
        public int idQuestion { get; set; }
        public string libelleQuestion { get; set; }
    }
}