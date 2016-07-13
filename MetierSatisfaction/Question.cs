using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierSatisfaction.Models
{
    public class Question
    {
        [Key]
        public int idQuestion { get; set; }
        public string libelleQuestion { get; set; }

        //les réponses relatives à la question

        public virtual ICollection<Reponse> Reponses { get; set; }
    }
}