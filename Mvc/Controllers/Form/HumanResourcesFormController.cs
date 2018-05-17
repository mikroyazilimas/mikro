using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "HumanResourcesForm", Title = "İnsan Kaynakaları Formu", SectionName = "FormModel")]
    public class HumanResourcesFormController : Controller
    {
        // GET: HumanResourcesForm
        public ActionResult Index()
        {
            try
            {
                HumanResourcesForm m = new HumanResourcesForm() { };
                return View(Names.PagesView.HumanResourcesForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }
    }
}