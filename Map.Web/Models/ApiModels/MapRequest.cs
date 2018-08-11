using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Web.Models.ApiModels
{
    public class MapRequest
    {
        public string MCC { get; set; }
        public string MNC { get; set; }
        public string CID { get; set; }
        public string LAC { get; set; }
    }
}