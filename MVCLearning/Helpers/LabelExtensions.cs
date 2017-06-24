using System;
using System.Web.Mvc;

namespace MVCLearning.Helpers
{
    public static class LabelExtensions
    {
        public static string MyLabel_string(this HtmlHelper helper, string target, string text)
        {
            var labelString = string.Format("<label for='{0}'>{1}</label>", target, text);

            return labelString;
        }

        public static MvcHtmlString MyLabel_MvcHtmlString(this HtmlHelper helper, string target, string text)
        {
            var labelString = string.Format("<label for='{0}'>{1}</label>", target, text);

            return MvcHtmlString.Create(labelString);
        }

        public static MvcHtmlString MyLabel_MvcHtmlStringUsingTagBuilder(this HtmlHelper helper, string target, string text)
        {
            var labelTag = new TagBuilder("label");
            labelTag.MergeAttribute("for", target);
            labelTag.InnerHtml = text;

            return MvcHtmlString.Create(labelTag.ToString());
        }
    }
}