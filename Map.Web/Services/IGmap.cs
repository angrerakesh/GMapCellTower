using Map.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Web.Services
{
    public interface IGmap
    {
        LocationDataModel GetLatLng(int MCC, int MNC, int LAC, int CID);
    }
}