using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Questionnaire
    {
        public int idQuestionnaire { get; set; }
        public string libelleQuestionnaire { get; set; }

        // Foreign key
        public int idType { get; set; }
        public virtual TypeQuestionnaire TypeQuestionnaire { get; set; }
        
        // les audits relatifs à un questionnaire donné
        public virtual ICollection<Audit> Audits { get; set; }
    }
}