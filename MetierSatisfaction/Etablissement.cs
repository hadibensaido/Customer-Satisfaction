using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierSatisfaction.Models
{
    public class Etablissement
    {
        [Key]
        public int idEtablissement { get; set; }
        public string libelleEtablissement { get; set; }
        public virtual ICollection<Client> client { get; set; }
        public virtual ICollection<Audit> audits { get; set; }
        public virtual ICollection<Utilisateur> users { get; set; }
    }
}