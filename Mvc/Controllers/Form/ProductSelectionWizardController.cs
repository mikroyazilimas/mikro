using SitefinityWebApp.Library;
using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "ProductSelectionWizard", Title = "Ürün Seçme Sihirbazı", SectionName = "FormModel")]
    public class ProductSelectionWizardController : Controller
    {
        // GET: ProductSelectionWizard
        public ActionResult Index()
        {
            SFProcess sf = new SFProcess();
            //sf.GetForm(Guid.Parse("57D3E456-2C5D-4636-9218-52310E744638"), "test");
            //sf.GetFormFieldValuesFromFormResponses("sf_mikroproduct", "test1");           

            ProductSelectionWizard m = new ProductSelectionWizard() {
                FormItems=sf.GetProductForm()
            };

            return View(Names.PagesView.ProductSelectionWizard, m);
        }
    }
}