using SitefinityWebApp.Library.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Library
{
    public static class C
    {        

        public static List<City> Cities
        {
            get
            {
                //if (HttpContext.Current.Cache[Names.Cache.Cities] == null)
                    //HttpContext.Current.Cache.Insert(Names.Cache.Cities, generalProcess2.GetCities().Cities, null, DateTime.Now.AddHours(1), System.Web.Caching.Cache.NoSlidingExpiration);
                return HttpContext.Current.Cache[Names.Cache.Cities] as List<City>;
            }
        }

        public static void Clear()
        {
            foreach (DictionaryEntry dEntry in HttpContext.Current.Cache)
            {
                HttpContext.Current.Cache.Remove(dEntry.Key.ToString());
            }
        }
    }
}