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
    
    #line 3 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
    using SitefinityWebApp.Mvc.Models.ViewModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
    using Telerik.Sitefinity.DynamicModules.Model;
    
    #line default
    #line hidden
    
    #line 4 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
    using Telerik.Sitefinity.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CorporateIdentity/List.CorporateIdentity.cshtml")]
    public partial class _MVC_Views_CorporateIdentity_List_CorporateIdentity_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_CorporateIdentity_List_CorporateIdentity_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
  
    List<KeyValuePair<string, string>> groups = Model.Items.Select(p => new KeyValuePair<string, string>(((ChoiceOption)p.Fields.GroupName).Text, ((ChoiceOption)p.Fields.GroupName).PersistedValue)).Distinct().ToList();
    List<LogoImage> LogoImageGroups = Model.Items.GroupBy(p => ((ChoiceOption)p.Fields.GroupName).Text).Select(x => new LogoImage
    {
        Group = x.Key,
        Items = x.Select(xx => new LogoImageItem
        {
            Title = xx.Fields.Title,
            File = ((Telerik.Sitefinity.Libraries.Model.Document)xx.Fields.File.DataItem).MediaUrl,
            Image = ((Telerik.Sitefinity.Frontend.Mvc.Models.ItemViewModel)xx.Fields.Image).Fields.MediaUrl
        }).ToList()
    }).OrderBy(p => groups.FirstOrDefault(pp => pp.Key == p.Group).Value).ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container-sub\"");

WriteLiteral(">\r\n\r\n");

            
            #line 20 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
     foreach (var ItemGroup in LogoImageGroups)
    {
        if (ItemGroup.Group != "Empty")
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"logo-title\"");

WriteLiteral(">\r\n                <h2>");

            
            #line 25 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
               Write(ItemGroup.Group);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n            </div>\r\n");

            
            #line 27 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"logo-content\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
             foreach (var item in ItemGroup.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"logo-content-item\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1427), Tuple.Create("\"", 1444)
            
            #line 32 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
, Tuple.Create(Tuple.Create("", 1434), Tuple.Create<System.Object, System.Int32>(item.File
            
            #line default
            #line hidden
, 1434), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n\r\n                        <div");

WriteLiteral(" class=\"logo-content-item-img\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1559), Tuple.Create("\"", 1576)
            
            #line 35 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(item.Image
            
            #line default
            #line hidden
, 1565), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"logo-content-item-title\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 38 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
                             Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                    </a>\r\n              " +
"  </div>\r\n");

            
            #line 42 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 44 "..\..\MVC\Views\CorporateIdentity\List.CorporateIdentity.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591