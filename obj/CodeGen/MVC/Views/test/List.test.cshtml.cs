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
    
    #line 3 "..\..\MVC\Views\test\List.test.cshtml"
    using SitefinityWebApp.Mvc.Models.ViewModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\MVC\Views\test\List.test.cshtml"
    using Telerik.Sitefinity.DynamicModules.Model;
    
    #line default
    #line hidden
    
    #line 4 "..\..\MVC\Views\test\List.test.cshtml"
    using Telerik.Sitefinity.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/test/List.test.cshtml")]
    public partial class _MVC_Views_test_List_test_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_test_List_test_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\MVC\Views\test\List.test.cshtml"
  
    List<LogoImage> LogoImageGroups = Model.Items.GroupBy(p => ((ChoiceOption)p.Fields.Group).Text).Select(x => new LogoImage
    {
        Group = x.Key,
        Items = x.Select(xx => new LogoImageItem
        {
            Title = xx.Fields.Title,
            File = ((Telerik.Sitefinity.Libraries.Model.Document)xx.Fields.File.DataItem).MediaUrl,
            Image = ((Telerik.Sitefinity.Frontend.Mvc.Models.ItemViewModel[])xx.Fields.Image)[0].Fields.MediaUrl
        }).ToList()
    }).ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"logo-content\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..\MVC\Views\test\List.test.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\MVC\Views\test\List.test.cshtml"
     foreach (var ItemGroup in LogoImageGroups)
    {
        if (ItemGroup.Group != "Empty")
        {

            
            #line default
            #line hidden
WriteLiteral("            <h2>");

            
            #line 23 "..\..\MVC\Views\test\List.test.cshtml"
           Write(ItemGroup.Group);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 24 "..\..\MVC\Views\test\List.test.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"logo-content-item\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\MVC\Views\test\List.test.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\MVC\Views\test\List.test.cshtml"
             foreach (var item in ItemGroup.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1030), Tuple.Create("\"", 1047)
            
            #line 28 "..\..\MVC\Views\test\List.test.cshtml"
, Tuple.Create(Tuple.Create("", 1037), Tuple.Create<System.Object, System.Int32>(item.File
            
            #line default
            #line hidden
, 1037), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"logo-content-item-img\"");

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1148), Tuple.Create("\"", 1165)
            
            #line 30 "..\..\MVC\Views\test\List.test.cshtml"
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create<System.Object, System.Int32>(item.Image
            
            #line default
            #line hidden
, 1154), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"logo-content-item-title\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 33 "..\..\MVC\Views\test\List.test.cshtml"
                         Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n");

            
            #line 36 "..\..\MVC\Views\test\List.test.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 38 "..\..\MVC\Views\test\List.test.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
