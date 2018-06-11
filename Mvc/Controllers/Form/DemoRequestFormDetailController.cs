using SitefinityWebApp.Library;
using SitefinityWebApp.Library.Model;
using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "DemoRequestDetailForm", Title = "Demo Talep Detay Formu", SectionName = "FormModel")]
    public class DemoRequestFormDetailController : Controller
    {
        // GET: DemoRequestFormDetail
        public ActionResult Index()
        {
            try
            {
                SFProcess sf = new SFProcess();
                //sf.GetForm(Guid.Parse("57D3E456-2C5D-4636-9218-52310E744638"), "test");
                //sf.GetFormFieldValuesFromFormResponses("sf_mikroproduct", "test1");

                sf.GetProductForm();

                DemoRequestForm m = new DemoRequestForm()
                {
                    refUrl = Request.UrlReferrer.ToString(),
                    Product = Request.QueryString["product"]
                };

                m.City = new DropDownListModel<Library.Model.City>
                {
                    Items = new List<City>() { new City() { Id = 34, Name = "İstanbul" } },
                    SelectedItem = new City() { Id = 34, Name = "İstanbul" },
                    Text = "Name",
                    Value = "Name"
                };

                m.County = new DropDownListModel<Library.Model.District>
                {
                    Items = new List<District>() { new District() { Id = 34, Name = "Ataköy" } },
                    SelectedItem = new District() { Id = 34, Name = "Ataköy" },
                    Text = "Name",
                    Value = "Name"
                };

                m.NumberOfEmployees = new DropDownListModel<KeyValue>
                {
                    Items = new List<KeyValue>() { new KeyValue() { Value = "1-5 kişi arası" }, new KeyValue() { Value = "6-10 kişi arası" }, new KeyValue() { Value = "11-20 kişi arası" }, new KeyValue() { Value = "21-50 kişi arası" }, new KeyValue() { Value = "50 kişi üzeri" } },
                    //SelectedItem = new City() { Id = 1, Name = "İstanbul" },
                    Text = "Value",
                    Value = "Value"
                };

                return View(Names.PagesView.DemoRequestDetailForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();

        }
    }
}