#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\UnitMeasuresList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bdd96ca19eb97773685a486b78f3df91135761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_UnitMeasuresList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/UnitMeasuresList.cshtml")]
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
#line 1 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\_ViewImports.cshtml"
using ERPv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\_ViewImports.cshtml"
using ERPv1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bdd96ca19eb97773685a486b78f3df91135761", @"/Views/Shared/EditorTemplates/UnitMeasuresList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296e1f1e7e985af1e596c25ff18c1e05b69fb24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_UnitMeasuresList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\UnitMeasuresList.cshtml"
   
    var Unit = _dbcontex.UnitMeasures.Select(x => new SelectListItem
    {
        Value = x.Id.ToString(),
        Text = x.UnitMeasureName
    }
    ).OrderBy(x => x.Text).ToList();


#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\UnitMeasuresList.cshtml"
   
    var htmlAtt = ViewData["htmlAtt"] ?? new { };


#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\UnitMeasuresList.cshtml"
Write(Html.DropDownList("", Unit, "--اختار--", htmlAtt));

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
