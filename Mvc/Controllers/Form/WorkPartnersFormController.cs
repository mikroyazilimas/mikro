using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "WorkPartnersForm", Title = "İş Ortakları Formu", SectionName = "FormModel")]
    public class WorkPartnersFormController : Controller
    {
        // GET: WorkPartnersForm
        public ActionResult Index()
        {
            try
            {

                WorkPartnersForm m = new WorkPartnersForm() { };

                return View(Names.PagesView.WorkPartnersForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }
    }
}