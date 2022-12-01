#pragma checksum "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\ProductTypesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dac1e2b586e29d236911fe2ab17cf44e4441524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_ProductTypesList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/ProductTypesList.cshtml")]
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
#line 1 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\_ViewImports.cshtml"
using ERPv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\_ViewImports.cshtml"
using ERPv1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dac1e2b586e29d236911fe2ab17cf44e4441524", @"/Views/Shared/EditorTemplates/ProductTypesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296e1f1e7e985af1e596c25ff18c1e05b69fb24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_ProductTypesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\ProductTypesList.cshtml"
   
    var Product = _dbcontex.ProductTypes.Select(x => new SelectListItem
    {
        Value = x.Id.ToString(),
        Text = x.ProductTypeName
    }
    ).OrderBy(x => x.Text).ToList();


#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\ProductTypesList.cshtml"
   
    var htmlAtt = ViewData["htmlAtt"] ?? new { };


#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\ProductTypesList.cshtml"
Write(Html.DropDownList("", Product, "--اختار--", htmlAtt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ERPv1.Data.ApplicationDbContext _dbcontex { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
