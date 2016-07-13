using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public delegate void AvoirCompteEventHandler(object sender, EventArgs e);

    public class Compte
    {
        public event AvoirCompteEventHandler AvoirCompte;
        #region ChampsCompte
        // Primary key 
        [Key]
        public int idCompte { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Veuillez renseigner le libellé du compte")]
        public string libelleCompte { get; set; }

        public virtual ICollection<Etablissement> etablissement { get; set; }
        public Profil profil { get; set;}
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