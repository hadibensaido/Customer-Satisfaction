using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Etablissement
    {
        #region Champs Etablissement
        public int idEtablissement;
        public string nameEtablissement {get; private set;}
        private ICollection<Client> clients;
        //private ICollection<IUser> users;
        #endregion
    }
}