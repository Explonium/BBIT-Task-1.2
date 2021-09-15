#pragma checksum "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4160a6c32dba0c1a8be8d1de04f23baf708da872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buildings_Create), @"mvc.1.0.view", @"/Views/Buildings/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4160a6c32dba0c1a8be8d1de04f23baf708da872", @"/Views/Buildings/Create.cshtml")]
    public class Views_Buildings_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BBIT_Task_1._2.Entities.Building>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Building</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Number"" class=""control-label""></label>
                <input asp-for=""Number"" class=""form-control"" />
                <span asp-validation-for=""Number"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Street"" class=""control-label""></label>
                <input asp-for=""Street"" class=""form-control"" />
                <span asp-validation-for=""Street"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div");
            WriteLiteral(@">
            <div class=""form-group"">
                <label asp-for=""Country"" class=""control-label""></label>
                <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostalIndex"" class=""control-label""></label>
                <input asp-for=""PostalIndex"" class=""form-control"" />
                <span asp-validation-for=""PostalIndex"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\VS Projects\BBIT Task 1.2\BBIT Task 1.2\Views\Buildings\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BBIT_Task_1._2.Entities.Building> Html { get; private set; }
    }
}
#pragma warning restore 1591
