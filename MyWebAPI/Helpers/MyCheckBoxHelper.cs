
using System;
using System.Web;
using System.Web.Mvc;

namespace MyWebAPI.Helpers
{
    public static class MyCheckBoxHelper
    {
        /*MyCheckBox*/
        public static IHtmlString MyCheckBox(this HtmlHelper helper, string id)
        {
            return new HtmlString(string.Format("<span>{0}</span>", id));
        }

        public static IHtmlString MyInput(this HtmlHelper helper, string id, string value)
        {
            var builder = new TagBuilder("input");

            builder.GenerateId(id);
            builder.MergeAttribute("value", value);
            return new HtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}