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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Form/Contact.cshtml")]
    public partial class _MVC_Views_Form_Contact_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.ViewModel.ContactForm>
    {
        public _MVC_Views_Form_Contact_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\MVC\Views\Form\Contact.cshtml"
 using (@Html.BeginForm("Index", "ContactForm", FormMethod.Post))
{ }

            
            #line default
            #line hidden
            
            #line 6 "..\..\MVC\Views\Form\Contact.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { action = "https://webto.salesforce.com/servlet/servlet.WebToLead?encoding=UTF-8" }))
{

            
            #line default
            #line hidden
WriteLiteral("<input");

WriteLiteral(" type=hidden");

WriteLiteral(" name=\"oid\"");

WriteLiteral(" value=\"00D0Y0000035HER\"");

WriteLiteral(">\r\n");

WriteLiteral("<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000RE6zR\"");

WriteLiteral(" name=\"00N0Y00000RE6zR\"");

WriteLiteral(" />\r\n");

WriteLiteral("<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000RBugB\"");

WriteLiteral(" name=\"00N0Y00000RBugB\"");

WriteLiteral(" value=\"Pre-sales channel\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\MVC\Views\Form\Contact.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\MVC\Views\Form\Contact.cshtml"
Write(Html.HiddenFor(m => m.retURL, new { Value = Const.FormReturnUrl }));

            
            #line default
            #line hidden
            
            #line 11 "..\..\MVC\Views\Form\Contact.cshtml"
                                                                       



            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox-form1\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\MVC\Views\Form\Contact.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { Name = "first_name", id = "first_name", required = "required", placeholder = "Ad*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\MVC\Views\Form\Contact.cshtml"
           Write(Html.TextBoxFor(m => m.Surname, new { Name = "last_name", id = "last_name", required = "required", placeholder = "Soyad*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\MVC\Views\Form\Contact.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { Name = "email", id = "email", required = "required", placeholder = "Email*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\MVC\Views\Form\Contact.cshtml"
           Write(Html.TextBoxFor(m => m.Phone, new { Name = "phone", id = "phone", required = "required", placeholder = "Telefon Numaranız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox-form2\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\MVC\Views\Form\Contact.cshtml"
           Write(Html.TextBoxFor(m => m.CompanyName, new { Name = "company", id = "company", required = "required", placeholder = "Şirketinizin ismi*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\MVC\Views\Form\Contact.cshtml"
       Write(Html.TextAreaFor(m => m.Message, new { Name = "00N0Y00000QeRBp", id = "00N0Y00000QeRBp", required = "required", placeholder = "Mesaj*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-button\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"SaveButton\"");

WriteLiteral(" value=\"Gönder\"");

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n");

            
            #line 41 "..\..\MVC\Views\Form\Contact.cshtml"


}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591