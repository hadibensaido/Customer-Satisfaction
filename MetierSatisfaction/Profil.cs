using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSatisfaction.Models
{
    public class Profil
    {
        [Key]
        public int idProfil { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Veuillez renseigner un libellé")]
        public string libelleProfil { get; set; }
    }
}