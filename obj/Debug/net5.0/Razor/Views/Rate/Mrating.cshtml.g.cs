#pragma checksum "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d191b03f59d9dd6795336c5a991cc7d412d2096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_Mrating), @"mvc.1.0.view", @"/Views/Rate/Mrating.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\MVCMovie\Views\_ViewImports.cshtml"
using MVCMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\MVCMovie\Views\_ViewImports.cshtml"
using MVCMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d191b03f59d9dd6795336c5a991cc7d412d2096", @"/Views/Rate/Mrating.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8780d8dcb399179cfee8fc4de5a52a3e176df588", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_Mrating : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCMovie.Models.Ratings>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
  
    ViewData["Title"] = "Mrating";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron justify-content-around\" style=\"background-color:aquamarine;border-radius:14px\">\r\n<h1>Mrating</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.DisplayNameFor(model => model.movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.DisplayNameFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.DisplayFor(modelItem => item.movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.DisplayFor(modelItem => item.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"badge rounded-pill badge-success \" style=\"font-size:x-large\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.ActionLink("Add Rating", "Addrating", new { id=item.movie }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </span>\r\n                |\r\n                <span class=\"badge rounded-pill badge-warning \" style=\"font-size:x-large\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.movie }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    <hr />\r\n    <button type=\"button\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1334, "\"", 1390, 5);
            WriteAttributeValue("", 1344, "location.href", 1344, 13, true);
            WriteAttributeValue(" ", 1357, "=", 1358, 2, true);
            WriteAttributeValue(" ", 1359, "\'", 1360, 2, true);
#nullable restore
#line 46 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Mrating.cshtml"
WriteAttributeValue("", 1361, Url.Action("Splash","Home"), 1361, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1389, "\'", 1389, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Go to Home</button>\r\n</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCMovie.Models.Ratings>> Html { get; private set; }
    }
}
#pragma warning restore 1591