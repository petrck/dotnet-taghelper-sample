using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotnetTagHelperSample.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
        }
    }
}