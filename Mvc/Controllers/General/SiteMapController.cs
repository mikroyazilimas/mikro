using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.General
{
    [ControllerToolboxItem(Name = "SiteMapForm", Title = "Site Haritası", SectionName = "GeneralModel")]
    public class SiteMapController : Controller
    {
        // GET: SiteMap
        public ActionResult Index()
        {
            return View(Names.PagesView.SiteMap);
        }
    }
}