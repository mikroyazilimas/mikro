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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginForm
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
    
    #line 4 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/LoginForm.LoginForm.cshtml")]
    public partial class LoginForm_LoginForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.LoginFormViewModel>
    {
        public LoginForm_LoginForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js",  "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
  
    var isTwoCols = (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0) ? "col-md-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 637), Tuple.Create("\"", 673)
            
            #line 17 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 645), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 645), false)
, Tuple.Create(Tuple.Create(" ", 660), Tuple.Create("row", 661), true)
, Tuple.Create(Tuple.Create(" ", 664), Tuple.Create("sf-m-xxs", 665), true)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
     if (Telerik.Sitefinity.Security.SecurityManager.GetCurrentUserId() == Guid.Empty || SystemManager.IsInlineEditingMode || SystemManager.IsDesignMode)
    {
        using (Html.BeginFormSitefinity(@Request.Url.Query, null, null, FormMethod.Post, null, true))
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 965), Tuple.Create("\"", 983)
            
            #line 22 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(isTwoCols
            
            #line default
            #line hidden
, 973), false)
);

WriteLiteral(">\r\n");

WriteLiteral("         ");

            
            #line 23 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t \t\t \r\n            <h3>");

            
            #line 25 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.Resource("LoginFormLogInLegendHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\t\t\t\r\n");

            
            #line 27 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Request.Url.Query.Contains("err=true") || Model.LoginError)
            {            

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 30 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("IncorrectCredentialsMessage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</div>                \r\n");

            
            #line 32 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label>\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("UserName"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.TextBoxFor(u => u.UserName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 40 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if(Html.ValidationMessage("UserName")!=null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 43 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.ValidationMessage("UserName"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n");

            
            #line 45 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }  

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label>\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.PasswordFor(u => u.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 55 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if(Html.ValidationMessage("Password") != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 58 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.ValidationMessage("Password"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n");

            
            #line 60 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }  

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n");

            
            #line 64 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ShowRememberMe || Model.ShowForgotPasswordLink)
            {
            var isPulledRight = Model.ShowRememberMe ? "" : "pull-right";


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2562), Tuple.Create("\"", 2599)
, Tuple.Create(Tuple.Create("", 2570), Tuple.Create("form-group", 2570), true)
, Tuple.Create(Tuple.Create(" ", 2580), Tuple.Create("row", 2581), true)
            
            #line 68 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create(" ", 2584), Tuple.Create<System.Object, System.Int32>(isPulledRight
            
            #line default
            #line hidden
, 2585), false)
);

WriteLiteral(">\r\n");

            
            #line 69 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRememberMe)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"checkbox col-md-6 sf-m-xxs\"");

WriteLiteral(">\r\n                    <label>\r\n");

WriteLiteral("                        ");

            
            #line 73 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.CheckBoxFor(u => u.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 74 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.Resource("RememberMe"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");

            
            #line 77 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 78 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowForgotPasswordLink)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"text-right sf-pr-l\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.ActionLink(Html.Resource("ForgottenPasword"), "ForgotPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 83 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 85 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\r\n\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 88 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         Write(Html.Resource("LoginFormLogInButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t</div>\r\n\r\n");

            
            #line 91 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 91 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ShowRegistrationLink)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"sf-registration-link\"");

WriteLiteral(">\r\n                    <div>");

            
            #line 94 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    Write(Html.Resource("NotRegisteredYet"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3580), Tuple.Create("\"", 3609)
            
            #line 95 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 3587), Tuple.Create<System.Object, System.Int32>(Model.RegisterPageUrl
            
            #line default
            #line hidden
, 3587), false)
);

WriteLiteral(">");

            
            #line 95 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                Write(Html.Resource("LoginFormRegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n");

            
            #line 97 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 99 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        
            if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">                \r\n                <h3>");

            
            #line 103 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("UseAccountIn"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 105 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 105 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 foreach (var provider in Model.ExternalProviders)
                { 
                    var classToBeAdd = "btn btn-default btn-lg btn-block " + @provider.Value;                 
                    
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"sf-mb-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 109 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 111 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 113 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }
		
        }
    }
    
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 120 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
      Write(Html.Resource("AlreadyLoggedIn"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 121 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 124 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginForm/login-form.js"), "bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
