using SitefinityWebApp.Library;
using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpPost]
        public ActionResult Index(AuthorizedDealerForm m)
        {
            try
            {
                MailHelper mail = new MailHelper();

                //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "satis@mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
                //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr","Mert.ALANKAYA@mikro.com.tr" };
                mail.To = new List<string>() { "kamil.turhan@ph.com.tr" };
                mail.From = "no-reply@e-mail.mikro.com.tr";
                mail.FromDisplayName = "Mikro";

                string body = String.Empty;
                using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/authorized-dealer.html"), System.Text.Encoding.UTF8))
                    body = sr.ReadToEnd();

                body = body.Replace("@@ad@@", m.Name);
                

                mail.Body = body;
                mail.Subject = "Yetkili Satıcı";
                bool rtn = mail.SendMail();

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