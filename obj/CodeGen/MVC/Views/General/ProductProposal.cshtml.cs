#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/General/ProductProposal.cshtml")]
    public partial class _MVC_Views_General_ProductProposal_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.ViewModel.ProductProposal>
    {
        public _MVC_Views_General_ProductProposal_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\MVC\Views\General\ProductProposal.cshtml"
 if (Model != null && Model.Product != null)
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"product-proposal\"");

WriteLiteral(">\r\n    <span>Doldurmuş olduğunuz bilgilere göre size aşağıdaki ürünleri öneriyoru" +
"z.</span>\r\n    \r\n");

            
            #line 8 "..\..\MVC\Views\General\ProductProposal.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\MVC\Views\General\ProductProposal.cshtml"
      if (Model.Product.IndexOf("1-5") != -1)
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"product-proposal-image\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-run\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 394), Tuple.Create("\"", 446)
, Tuple.Create(Tuple.Create("", 400), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/products/run-banner.png")
, 400), false)
);

WriteLiteral(" /></a>\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-run\"");

WriteLiteral(" class=\"homepage-new-product-item-link\"");

WriteLiteral(">Detay</a>\r\n    </div>\r\n");

            
            #line 14 "..\..\MVC\Views\General\ProductProposal.cshtml"
        }
        else if (Model.Product.IndexOf("6-50") != -1)
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"product-proposal-image\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-jump\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 742), Tuple.Create("\"", 795)
, Tuple.Create(Tuple.Create("", 748), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/products/jump-banner.png")
, 748), false)
);

WriteLiteral(" /></a>\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-jump\"");

WriteLiteral(" class=\"homepage-new-product-item-link\"");

WriteLiteral(">Detay</a>\r\n    </div>\r\n");

            
            #line 21 "..\..\MVC\Views\General\ProductProposal.cshtml"
        }
        else if (Model.Product.IndexOf("51") != -1)
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"product-proposal-image\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-fly\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1089), Tuple.Create("\"", 1141)
, Tuple.Create(Tuple.Create("", 1095), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/products/fly-banner.png")
, 1095), false)
);

WriteLiteral(" /></a>\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-fly\"");

WriteLiteral(" class=\"homepage-new-product-item-link\"");

WriteLiteral(">Detay</a>\r\n    </div>\r\n");

            
            #line 28 "..\..\MVC\Views\General\ProductProposal.cshtml"
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 31 "..\..\MVC\Views\General\ProductProposal.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
