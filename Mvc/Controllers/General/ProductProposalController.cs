using SitefinityWebApp.Mvc.Models.ViewModel;
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
            
            if (!String.IsNullOrEmpty(Request.QueryString["product"]))
            {
                ProductProposal productProposal = new ProductProposal()
                {
                    Product = Request.QueryString["product"]
                };
                return View(Names.PagesView.ProductProposal,productProposal);
            }

            return View(Names.PagesView.ProductProposal);
        }
    }
}