using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSatisfaction.Models
{
    public class Client:Segment
    {
        int idClient { get; set; }
        string nomClient { get; set; }
    }
}