using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.General
{

    [ControllerToolboxItem(Name = "ProductProposal", Title = "Ürün Öneri", SectionName = "GeneralModel")]
    public class ProductProposalController : Controller
    {
        // GET: ProductProposal
        public ActionResult Index()
        {
            return View(Names.PagesView.ProductProposal);
        }
    }
}