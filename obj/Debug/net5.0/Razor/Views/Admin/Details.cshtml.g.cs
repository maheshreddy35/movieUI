#pragma checksum "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b36f16f0f58635c35e1429a2b02c9dd56bbfe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b36f16f0f58635c35e1429a2b02c9dd56bbfe4", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8780d8dcb399179cfee8fc4de5a52a3e176df588", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCMovie.Models.Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron jumbotron-fluid\" style=\"background-color:aquamarine;border-radius:15px\">\r\n\r\n<h1 class=\"text-center\">Details</h1>\r\n\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-outline-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 289, "\"", 350, 5);
            WriteAttributeValue("", 299, "location.href", 299, 13, true);
            WriteAttributeValue(" ", 312, "=", 313, 2, true);
            WriteAttributeValue(" ", 314, "\'", 315, 2, true);
#nullable restore
#line 11 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
WriteAttributeValue("", 316, Url.Action("AddTheater","Admin"), 316, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 349, "\'", 349, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Create New</button>\r\n</p>\r\n<table class=\" table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Theatername));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Theatername));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"font-size:x-large\">\r\n                <span class=\"badge rounded-pill badge-success\">\r\n                ");
#nullable restore
#line 54 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.ActionLink(" Edit ", "EditTheater", new {id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </span>|\r\n                <span class=\"badge rounded-pill badge-warning\">\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
           Write(Html.ActionLink(" Delete ", "DeleteTheater", new {id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2030, "\"", 2086, 5);
            WriteAttributeValue("", 2040, "location.href", 2040, 13, true);
            WriteAttributeValue(" ", 2053, "=", 2054, 2, true);
            WriteAttributeValue(" ", 2055, "\'", 2056, 2, true);
#nullable restore
#line 65 "C:\Users\Admin\source\repos\MVCMovie\Views\Admin\Details.cshtml"
WriteAttributeValue("", 2057, Url.Action("Index","Admin"), 2057, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2085, "\'", 2085, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Go to Home</button>\r\n    \r\n</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCMovie.Models.Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
