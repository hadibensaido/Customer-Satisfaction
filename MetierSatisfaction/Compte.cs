using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public delegate void EstClientEventHandler(object sender, EventArgs e);

    public class Compte
    {
        public event EstClientEventHandler AvoirCompte;
        #region ChampsCompte
        public int idCompte { get; set; }
        public string libelleCompte { get; set; }
        #endregion

        #region Méthode
        private bool OnAvoirCompte()
        {
            if (AvoirCompte != null)
            {
                AvoirCompte(this, new EventArgs());
                return true;
            }
            else
                return false;
        }

        public bool signerContrat()
        {
            if (OnAvoirCompte())
                return true;
            return false;  
        }
        #endregion
    }
}