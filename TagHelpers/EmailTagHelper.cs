using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CandyShop.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Adress { get; set; }
        public string LinkTest { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Adress);
            output.Content.SetContent(LinkTest);
        }
    }
}
