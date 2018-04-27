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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SocialShare
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
    
    #line 3 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.SocialShare.SocialShareHelpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SocialShare/SocialShareIconsWithText.cshtml")]
    public partial class SocialShareIconsWithText : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.SocialShare.Mvc.Models.SocialShareModel>
    {
        public SocialShareIconsWithText()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
  
    var shareUrl = SocialShareButtons.ShareUrl;
    var unencodedPageTitle = Model.ItemTitle != null ? Model.ItemTitle : SocialShareButtons.PageTitle;
    var pageTitle = HttpUtility.UrlEncode(unencodedPageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 12 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/dist/css/sf-social-share.min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.Script(ScriptRef.JQuery, "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style>\r\n    .color {color: blue;}\r\n</style>\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 657), Tuple.Create("\"", 680)
            
            #line 19 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 665), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 665), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-inline sf-social-share\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
         foreach (var button in Model.SocialButtons)
        {
            switch (button.ButtonName)
            {
                case "Facebook":

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 26 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                         Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\'fb-share-button\'");

WriteLiteral(" data-href=\'");

            
            #line 27 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                           Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-type=\'button_count\'");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" id=\'fb-root\'");

WriteLiteral(@"></div>
                        <script>
                            (function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = '//connect.facebook.net/en_EN/all.js#xfbml=1'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));
                        </script>
                    </li>
");

            
            #line 33 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Twitter":

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 35 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                         Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\'https://twitter.com/share\'");

WriteLiteral(" title=\'Share on Twitter\'");

WriteLiteral(" class=\'twitter-share-button\'");

WriteLiteral(" data-url=");

            
            #line 36 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                                                                      Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral(" data-count=\'horizontal\'");

WriteLiteral(@">
                            Tweet
                        </a>
                        <script>
                            !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } }(document, 'script', 'twitter-wjs');
                        </script>
                    </li>
");

            
            #line 43 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "LinkedIn":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 45 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <script");

WriteLiteral(" src=\"//platform.linkedin.com/in.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                        lang: en_US\r\n                    </script>\r\n          " +
"          <script");

WriteLiteral(" type=\"IN/Share\"");

WriteLiteral(" data-url=\'");

            
            #line 49 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                 Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-counter=\"right\"");

WriteLiteral(">\r\n                    </script>\r\n                </li>\r\n");

            
            #line 52 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GooglePlusOne":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 54 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\'g-plusone\'");

WriteLiteral(" data-size=\'medium\'");

WriteLiteral(" data-callback=\"googleShareCallback\"");

WriteLiteral("></div>\r\n                    <script");

WriteLiteral(" type=\'text/javascript\'");

WriteLiteral(@">
                        (function () { var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; po.src = 'https://apis.google.com/js/platform.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s); })();
                    </script>
                </li>
");

            
            #line 60 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Blogger":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 62 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3680), Tuple.Create("\"", 3829)
, Tuple.Create(Tuple.Create("", 3690), Tuple.Create("window.open(\'https://www.blogger.com/blog_this.pyra?t&u=", 3690), true)
            
            #line 63 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 3746), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 3746), false)
, Tuple.Create(Tuple.Create("", 3755), Tuple.Create("&n=", 3755), true)
            
            #line 63 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 3758), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 3758), false)
, Tuple.Create(Tuple.Create("", 3768), Tuple.Create("\',", 3768), true)
, Tuple.Create(Tuple.Create(" ", 3770), Tuple.Create("\'Blogger\',\'toolbar=no,width=550,height=550\');", 3771), true)
, Tuple.Create(Tuple.Create(" ", 3816), Tuple.Create("return", 3817), true)
, Tuple.Create(Tuple.Create(" ", 3823), Tuple.Create("false", 3824), true)
);

WriteLiteral(" title=\"Share on Blogger\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-blogger\"");

WriteLiteral("></span>\r\n                        <strong>Blogger</strong>\r\n                    <" +
"/a>\r\n                </li>\r\n");

            
            #line 68 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Delicious":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 70 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4210), Tuple.Create("\"", 4391)
, Tuple.Create(Tuple.Create("", 4220), Tuple.Create("window.open(\'https://delicious.com/save?v=5&provider=Telerik&noui&jump=close&url=" +
"", 4220), true)
            
            #line 71 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                          , Tuple.Create(Tuple.Create("", 4301), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 4301), false)
, Tuple.Create(Tuple.Create("", 4310), Tuple.Create("&title=", 4310), true)
            
            #line 71 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 4317), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 4317), false)
, Tuple.Create(Tuple.Create("", 4327), Tuple.Create("\',", 4327), true)
, Tuple.Create(Tuple.Create(" ", 4329), Tuple.Create("\'delicious\',\'toolbar=no,width=550,height=550\');", 4330), true)
, Tuple.Create(Tuple.Create(" ", 4377), Tuple.Create("return", 4378), true)
, Tuple.Create(Tuple.Create(" ", 4384), Tuple.Create("false;", 4385), true)
);

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"https://delicious.com/img/logo.png\"");

WriteLiteral(" height=\"16\"");

WriteLiteral(" width=\"16\"");

WriteLiteral(" alt=\"Delicious\"");

WriteLiteral("> Save this on Delicious\r\n                    </a>\r\n                </li>\r\n");

            
            #line 75 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Tumblr":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 77 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" onclick=\"window.open(\'http://www.tumblr.com/share\', \'Tumblr\',\'toolbar=no,width=9" +
"00,height=550\')\"");

WriteLiteral(";S");

WriteLiteral(" title=\"Share on Tumblr\"");

WriteLiteral(" style=\"display:inline-block; text-indent:-9999px; overflow:hidden; width:81px; h" +
"eight:20px; background:url(\'https://platform.tumblr.com/v1/share_1.png\') top lef" +
"t no-repeat transparent;\"");

WriteLiteral(">Share on Tumblr</a>\r\n                </li>\r\n");

            
            #line 80 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GoogleBookmarks":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 82 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5339), Tuple.Create("\"", 5508)
, Tuple.Create(Tuple.Create("", 5349), Tuple.Create("window.open(\'https://www.google.com/bookmarks/mark?op=add&bkmk=", 5349), true)
            
            #line 83 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                , Tuple.Create(Tuple.Create("", 5412), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5412), false)
, Tuple.Create(Tuple.Create("", 5421), Tuple.Create("&title=", 5421), true)
            
            #line 83 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 5428), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5428), false)
, Tuple.Create(Tuple.Create("", 5438), Tuple.Create("\',", 5438), true)
, Tuple.Create(Tuple.Create(" ", 5440), Tuple.Create("\'Google", 5441), true)
, Tuple.Create(Tuple.Create(" ", 5448), Tuple.Create("bookmarks\',\'toolbar=no,width=550,height=550\');", 5449), true)
, Tuple.Create(Tuple.Create(" ", 5495), Tuple.Create("return", 5496), true)
, Tuple.Create(Tuple.Create(" ", 5502), Tuple.Create("false", 5503), true)
);

WriteLiteral(" title=\"Share on GoogleBookmarks\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-google\"");

WriteLiteral("></span>\r\n                        <strong>Google Bookmarks</strong>\r\n            " +
"        </a>\r\n                </li>\r\n");

            
            #line 88 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Digg":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 90 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5924), Tuple.Create("\"", 6058)
, Tuple.Create(Tuple.Create("", 5934), Tuple.Create("window.open(\'http://digg.com/submit?url=", 5934), true)
            
            #line 91 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                         , Tuple.Create(Tuple.Create("", 5974), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5974), false)
, Tuple.Create(Tuple.Create("", 5983), Tuple.Create("&title=", 5983), true)
            
            #line 91 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 5990), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5990), false)
, Tuple.Create(Tuple.Create("", 6000), Tuple.Create("\',", 6000), true)
, Tuple.Create(Tuple.Create(" ", 6002), Tuple.Create("\'Digg\',\'toolbar=no,width=550,height=550\');", 6003), true)
, Tuple.Create(Tuple.Create(" ", 6045), Tuple.Create("return", 6046), true)
, Tuple.Create(Tuple.Create(" ", 6052), Tuple.Create("false", 6053), true)
);

WriteLiteral(" title=\"Share on Digg\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-digg\"");

WriteLiteral("></span> <strong>Digg</strong>\r\n                    </a>\r\n                </li>\r\n" +
"");

            
            #line 95 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "MySpace":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 97 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 6427), Tuple.Create("\"", 6577)
, Tuple.Create(Tuple.Create("", 6437), Tuple.Create("window.open(\'http://myspace.com/Modules/PostTo/Pages/?u=", 6437), true)
            
            #line 98 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 6493), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 6493), false)
, Tuple.Create(Tuple.Create("", 6502), Tuple.Create("&t=", 6502), true)
            
            #line 98 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 6505), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 6505), false)
, Tuple.Create(Tuple.Create("", 6515), Tuple.Create("\',", 6515), true)
, Tuple.Create(Tuple.Create(" ", 6517), Tuple.Create("\'My", 6518), true)
, Tuple.Create(Tuple.Create(" ", 6521), Tuple.Create("Space\',\'toolbar=no,width=550,height=550\');", 6522), true)
, Tuple.Create(Tuple.Create(" ", 6564), Tuple.Create("return", 6565), true)
, Tuple.Create(Tuple.Create(" ", 6571), Tuple.Create("false", 6572), true)
);

WriteLiteral(" title=\"Share on MySpace\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-myspace\"");

WriteLiteral("></span>\r\n                        <strong>MySpace</strong>\r\n                    <" +
"/a>\r\n                </li>\r\n");

            
            #line 103 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "StumbleUpon":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 105 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <!-- Place this tag where you want the su badge to render " +
"-->\r\n                    <su:badge");

WriteLiteral(" layout=\"2\"");

WriteLiteral("></su:badge>\r\n\r\n                    <!-- Place this snippet wherever appropriate " +
"-->\r\n                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                        (function () {
                            var li = document.createElement('script'); li.type = 'text/javascript'; li.async = true;
                            li.src = ('https:' == document.location.protocol ? 'https:' : 'http:') + '//platform.stumbleupon.com/1/widgets.js';
                            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(li, s);
                        })();
                    </script>

                </li>
");

            
            #line 119 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Reddit":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 121 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"//www.reddit.com/submit\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 7905), Tuple.Create("\"", 7986)
, Tuple.Create(Tuple.Create("", 7915), Tuple.Create("window.location", 7915), true)
, Tuple.Create(Tuple.Create(" ", 7930), Tuple.Create("=", 7931), true)
, Tuple.Create(Tuple.Create(" ", 7932), Tuple.Create("\'//www.reddit.com/submit?url=", 7933), true)
            
            #line 122 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                              , Tuple.Create(Tuple.Create("", 7962), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 7962), false)
, Tuple.Create(Tuple.Create("", 7971), Tuple.Create("\';", 7971), true)
, Tuple.Create(Tuple.Create(" ", 7973), Tuple.Create("return", 7974), true)
, Tuple.Create(Tuple.Create(" ", 7980), Tuple.Create("false", 7981), true)
);

WriteLiteral("> <img");

WriteLiteral(" src=\"//www.redditstatic.com/spreddit7.gif\"");

WriteLiteral(" alt=\"submit to reddit\"");

WriteLiteral(" border=\"0\"");

WriteLiteral(" /> </a>\r\n                </li>\r\n");

            
            #line 124 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;

                case "MailTo":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 127 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8283), Tuple.Create("\"", 8331)
, Tuple.Create(Tuple.Create("", 8290), Tuple.Create("mailto:?body=", 8290), true)
            
            #line 128 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 8303), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 8303), false)
, Tuple.Create(Tuple.Create("", 8312), Tuple.Create("&subject=", 8312), true)
            
            #line 128 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 8321), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 8321), false)
);

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" title=\"Tell a friend\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-mailto\"");

WriteLiteral("></span>\r\n                        <strong>Email</strong>\r\n                    </a" +
">\r\n                </li>\r\n");

            
            #line 133 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                default:
                    break;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

            
            #line 141 "..\..MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SocialShare/social-share.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
