#pragma checksum "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\WaterCalculator\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5239d65d3ab2e1bd14a1c472f4880c31392dc7fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WaterCalculator_Result), @"mvc.1.0.view", @"/Views/WaterCalculator/Result.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\_ViewImports.cshtml"
using WaterCalculator.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\_ViewImports.cshtml"
using WaterCalculator.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\WaterCalculator\Result.cshtml"
using WaterCalculator.Web.ViewModels.Water;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5239d65d3ab2e1bd14a1c472f4880c31392dc7fd", @"/Views/WaterCalculator/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779efae4a40261941256936455906852b98ed0d3", @"/Views/_ViewImports.cshtml")]
    public class Views_WaterCalculator_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaterOutputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\WaterCalculator\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div class=\"text-center\">\r\n    <img src=\"https://cleanleap.com/sites/default/files/images/featured/3310/water%20cup.jpg\" class=\"rounded\" width=\"500\" height=\"250\">\r\n    <br />\r\n    <h3>You should drink ");
#nullable restore
#line 10 "C:\Users\sveto\Desktop\SoftUni\WaterCalculator\Web\WaterCalculator.Web\Views\WaterCalculator\Result.cshtml"
                    Write(Model.MililitersToDrink);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mililiters per day.</h3>\r\n    <br />\r\n    <a href=\"/\">\r\n        <input type=\"submit\" value=\"Home\" class=\"btn btn-secondary\" />\r\n    </a>\r\n</div>\r\n\r\n    \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WaterOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
