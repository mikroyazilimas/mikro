﻿using SitefinityWebApp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitefinityWebApp.App_Master
{
    public partial class Non_menuPages : System.Web.UI.MasterPage
    {
        public bool IsDesignMode { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["gclid"]))
                WebTools.SetCookie(Names.Cookie.Gclid, Request.QueryString["gclid"], DateTime.Now.AddHours(1));


            if (Request.Url.ToString().IndexOf("Action/Edit") != -1 || Request.Url.ToString().IndexOf("Template") != -1)
                IsDesignMode = true;
            else
                IsDesignMode = false;
        }
    }
}