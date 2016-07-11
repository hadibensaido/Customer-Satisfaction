using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Invitation:Client
    {
        int idInvitation { get; set; }
        DateTime dateEvoi { get; set; }
        String libelleInvitation { get; set; }
    }
}