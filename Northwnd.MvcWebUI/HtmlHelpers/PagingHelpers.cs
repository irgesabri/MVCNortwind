using Northwnd.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.MvcWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html,PageInfo pageinfo)
        {
            int totalPage = (int)Math.Ceiling((decimal)pageinfo.TotalItems / pageinfo.ItemsPerPage);
            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= totalPage; i++)
            {
                 var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("/Product/Index/?page={0}&category={1}", i,pageinfo.CurrentCategory));
                tagBuilder.InnerHtml = i.ToString();
                if (pageinfo.CurrrentPage==i)
                {
                    tagBuilder.AddCssClass("selected");                       
                }
                stringBuilder.Append(tagBuilder);
            }
            return MvcHtmlString.Create(stringBuilder.ToString());
        }
    }
}