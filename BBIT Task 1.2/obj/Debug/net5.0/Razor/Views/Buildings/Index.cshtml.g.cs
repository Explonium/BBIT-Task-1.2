#pragma checksum "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37fd2d2136e5afdfde7644d57508ce27b7bad9fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buildings_Index), @"mvc.1.0.view", @"/Views/Buildings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fd2d2136e5afdfde7644d57508ce27b7bad9fa", @"/Views/Buildings/Index.cshtml")]
    public class Views_Buildings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BBIT_Task_1._2.Entities.Building>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostalIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostalIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1369, "\"", 1392, 1);
#nullable restore
#line 52 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
WriteAttributeValue("", 1384, item.Id, 1384, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1445, "\"", 1468, 1);
#nullable restore
#line 53 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
WriteAttributeValue("", 1460, item.Id, 1460, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1523, "\"", 1546, 1);
#nullable restore
#line 54 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
WriteAttributeValue("", 1538, item.Id, 1538, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BBIT_Task_1._2.Entities.Building>> Html { get; private set; }
    }
}
#pragma warning restore 1591
