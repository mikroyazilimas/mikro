using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Pages.Model;

namespace SitefinityWebApp.Library
{
    public class ToolsSF
    {

        public List<PageNode> GetMegaMenu(string parentPageUrl)
        {
            List<PageNode> pageNodes = new List<PageNode>();
            if (parentPageUrl != "")
            {
                parentPageUrl = parentPageUrl.Replace("/", "").Replace("~", "");
                pageNodes = Telerik.Sitefinity.App.WorkWith().Pages().Where(ii => ii.Parent != null && ii.ShowInNavigation == true && ii.Parent.UrlName == parentPageUrl).OrderBy(item => item.Ordinal).Get().ToList();

            }
            return pageNodes;
        }
    }

    
}