using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Reponse
    {
        public string commentaire { get; set; }
        public int idReponse { get; set; }
        public string reponse { get; set; }

        // la question concernée
        public int idQuestion { get; set; }
        public virtual Question Question { get; set; }
    }
}