using SitefinityWebApp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitefinityWebApp.Mvc.Base
{
    public class ControlBase : Controller
    {
        public LogProcess logProcess = new LogProcess();
        public MembershipProcess membershipProcess = new MembershipProcess();
    }
}