using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class TypeQuestionnaire
    {
        public int idType { get; set; }
        public string libelleType { get; set; }

        // les questionnaires d'un même type
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}