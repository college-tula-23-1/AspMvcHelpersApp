using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace AspMvcHelpersApp.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateUL(this IHtmlHelper htmlHelper, string[] items, string title = "")
        {
            string html = $"<h3>{title}</h3><ul>";

            foreach (var item in items)
                html += $"<li>{item}</li>";

            html += "</ul>";

            return new HtmlString(html) ;
        }

        public static HtmlString CreateOL(this IHtmlHelper htmlHelper, string[] items, string title = "")
        {
            TagBuilder ol = new("ol");
            foreach(var item in items)
            {
                TagBuilder li = new("li");
                li.InnerHtml.Append(item);
                li.AddCssClass("list-group-item");
                ol.InnerHtml.AppendHtml(li);
            }
            ol.AddCssClass("list-group");
            ol.AddCssClass("list-group-numbered");

            StringWriter writer = new();
            ol.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }
    }
}
