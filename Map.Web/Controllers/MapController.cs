using Map.Web.Helpers;
using Map.Web.Models;
using Map.Web.Models.ApiModels;
using Map.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Map.Web.Controllers
{
    public class MapController : ApiController
    {
        public LocationDataModel Post([FromBody]MapRequest req)
        {
            return GMapApi.GetLatLng(CommonHelper.GetIntValue(req.MCC), CommonHelper.GetIntValue(req.MNC), CommonHelper.GetIntValue(req.LAC), CommonHelper.GetIntValue(req.CID));
        }
    }
}
