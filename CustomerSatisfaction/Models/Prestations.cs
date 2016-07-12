using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public abstract class Prestations
    {
        int idPrestation { get; set; }
        DateTime datePrestation { get; set; }
    }
}