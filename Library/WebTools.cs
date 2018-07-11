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

        public static string GetIpAddress
        {
            get
            {
                string ipAddress;
                try { ipAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]; }
                catch { ipAddress = "0"; }
                return ipAddress;
            }
        }

        public static void DeleteCookie(string cookieName)
        {
            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Value = "";
            cookie.Expires = DateTime.Now.AddDays(-1d);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static void SetCookie(string cookieName, string value, DateTime expireDate)
        {
            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Value = value;
            cookie.Expires = expireDate;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static string GetCookieValue(string cookieName)
        {
            string retVal = string.Empty;
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
            if (cookie != null)
                retVal = cookie.Value;
            return retVal;
        }
    }
}