using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Utilisateur
    {
        // Primary key 
        [Key]
        public int idUtilisateur { get; set; }

        [Required]
        [StringLength(50)]
        public string nomUtilisateur { get; set; }

        // Navigation properties 
        ICollection<Profil> profil { get; set; }
    }
}