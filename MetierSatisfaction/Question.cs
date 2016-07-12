using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Question
    {
        public int idQuestion { get; set; }
        public string libelleQuestion { get; set; }

        // les réponses relatives à la question
        public virtual ICollection<Reponse> Reponses { get; set; }
    }
}