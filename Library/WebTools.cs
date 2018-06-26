using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Library
{
    public class WebTools
    {
        public static string GetQueryStringValueFromRawUrl(string queryStringKey)
        {
            var currentUri = new Uri(HttpContext.Current.Request.Url.Scheme + "://" +
                HttpContext.Current.Request.Url.Authority +
                HttpContext.Current.Request.RawUrl);
            var queryStringCollection = HttpUtility.ParseQueryString((currentUri).Query);
            return queryStringCollection.Get(queryStringKey);
        }
    }
}