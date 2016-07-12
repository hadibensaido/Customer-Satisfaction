using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Etablissement
    {
        public int idEtablissement { get; set; }
        public string libelleEtablissement { get; set; }
        public virtual ICollection<Client> clients { get; private set; }
        public virtual ICollection<Utilisateur> utilisateurs { get; private set; }
        public virtual ICollection<Audit> audit { get; private set; }
    }
}