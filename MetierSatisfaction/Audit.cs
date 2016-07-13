using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Audit
    {
        public DateTime dateAudit { get; set; }
        [Key]
        public int idAudit { get; set; }
        public string libelleAudit { get; set; }

        // Foreign key Etablissement, Questionnaire
        [ForeignKey("Etablissement")]
        public int idEtablissement { get; set; }
        public virtual Etablissement Etablissement { get; set; }

        [ForeignKey("Questionnaire")]
        public int idQuestionnaire { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
    }
}