using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Prestations:Client
    {
        int idPrestation { get; set; }
        DateTime datePrestation { get; set; }
    }
}