using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Web.Helpers
{
    public class CommonHelper
    {
        public static int GetIntValue(string val)
        {
            int i = 0;
            int.TryParse(val, out i);
            return i;
        }
    }
}