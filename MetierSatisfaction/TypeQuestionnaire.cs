using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class TypeQuestionnaire
    {
        [Key]
        public int idType { get; set; }
        public string libelleType { get; set; }

        // les questionnaires d'un même type
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}