using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierSatisfaction.Models
{
    public class Questionnaire
    {
        [Key]
        public int idQuestionnaire { get; set; }
        public string libelleQuestionnaire { get; set; }

        // Foreign key
        [ForeignKey("TypeQuestionnaire")]
        public int idType { get; set; }
        public virtual TypeQuestionnaire TypeQuestionnaire { get; set; }

        // les audits relatifs à un questionnaire donné
        
        public virtual ICollection<Audit> Audits { get; set; }
    }
}