using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierSatisfaction.Models
{
    public class Etablissement
    {
        //Primary Key
        [Key]
        public int idEtablissement { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Veuillez renseigner le nom de l'établissement")]
        public string libelleEtablissement { get; set; }

        public virtual ICollection<Client> client { get; set; }
        public virtual ICollection<Audit> audits { get; set; }
        public virtual ICollection<Utilisateur> users { get; set; }
    }
}