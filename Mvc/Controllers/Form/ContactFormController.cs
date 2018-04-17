using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "ContactForm", Title = "İletişim Formu", SectionName = "FormModel")]
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            try
            {

                ContactForm m = new ContactForm() { };                

                return View(Names.PagesView.ContactForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }
    }
}