using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Compte
    {
        #region ChampsCompte
        public int idCompte { get; set; }
        public string libelleCompte { get; set; }
        #endregion

        #region Méthode
        public bool signerContrat()
        {
            Client c;
            List<Client> clients;

            c = new Client();
            clients = new List<Client>();
            if(clients != null)
                if (bool.Parse(clients.Add(c))
                {
                    return true;
                }
            return false;
        }
        #endregion
    }
}