using SitefinityWebApp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitefinityWebApp.App_Master
{
    public partial class Page : System.Web.UI.MasterPage
    {
        public string NoIndex { get; set; }
        public bool IsDesignMode { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["gclid"]))
                WebTools.SetCookie(Names.Cookie.Gclid, Request.QueryString["gclid"], DateTime.Now.AddHours(1));

            if (!String.IsNullOrEmpty(Request.QueryString["utm_campaign"]))
                WebTools.SetCookie(Names.Cookie.UtmCampaign, Request.QueryString["utm_campaign"], DateTime.Now.AddHours(1));

            if (!String.IsNullOrEmpty(Request.QueryString["utm_medium"]))
                WebTools.SetCookie(Names.Cookie.UtmMedium, Request.QueryString["utm_medium"], DateTime.Now.AddHours(1));

            if (!String.IsNullOrEmpty(Request.QueryString["utm_source"]))
                WebTools.SetCookie(Names.Cookie.UtmSource, Request.QueryString["utm_source"], DateTime.Now.AddHours(1));

            if (Request.Url.ToString().IndexOf("Action/Edit") != -1 || Request.Url.ToString().IndexOf("Template") != -1)
                IsDesignMode = true;
            else
                IsDesignMode = false;

            if (Request.Url.ToString().TrimEnd('/').Contains("is-ortaklarimiz/"))
                NoIndex = "<meta name=\"robots\" content=\"noindex\">";
        }
    }
}