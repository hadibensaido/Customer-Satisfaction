using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Audit
    {
        public DateTime dateAudit { get; set; }
        public int idAudit { get; set; }
        public string libelleAudit { get; set; }
    }
}