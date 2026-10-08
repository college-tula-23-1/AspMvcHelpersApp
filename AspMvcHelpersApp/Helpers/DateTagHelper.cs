using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspMvcHelpersApp.Helpers
{
    public class DateTagHelper : TagHelper
    {
        public bool IsShort { get; set; } = true;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";

            string date = IsShort ? DateTime.Now.ToShortDateString() : DateTime.Now.ToLongDateString();

            output.Content.SetContent($"{date}");
        }
    }
}
