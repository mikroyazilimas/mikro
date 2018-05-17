using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "AuthorizedDealerForm", Title = "Yetkili Satıcı Formu", SectionName = "FormModel")]
    public class AuthorizedDealerFormController : Controller
    {
        // GET: AuthorizedDealerForm
        public ActionResult Index()
        {
            try
            {

                AuthorizedDealerForm m = new AuthorizedDealerForm() { };

                return View(Names.PagesView.AuthorizedDealerForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }
    }
}