#pragma checksum "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cffdaf23903d7cc03620b93d73cac155f3b9e274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_Details), @"mvc.1.0.view", @"/Views/Rate/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffdaf23903d7cc03620b93d73cac155f3b9e274", @"/Views/Rate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8780d8dcb399179cfee8fc4de5a52a3e176df588", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMovie.Models.Ratings>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron jumbotron-fluid\" style=\"background-color:brown;border-radius:14px\">\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Ratings</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
       Write(Html.DisplayFor(model => model.movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
       Write(Html.DisplayFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 743, "\"", 799, 5);
            WriteAttributeValue("", 753, "location.href", 753, 13, true);
            WriteAttributeValue(" ", 766, "=", 767, 2, true);
            WriteAttributeValue(" ", 768, "\'", 769, 2, true);
#nullable restore
#line 28 "C:\Users\Admin\source\repos\MVCMovie\Views\Rate\Details.cshtml"
WriteAttributeValue("", 770, Url.Action("Splash","Home"), 770, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 798, "\'", 798, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Go to Home</button>\r\n</p>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMovie.Models.Ratings> Html { get; private set; }
    }
}
#pragma warning restore 1591