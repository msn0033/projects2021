#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\StoreSystemEnumList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb8b8eebb4e80c24d92e6dde721ec6f42249f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_StoreSystemEnumList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/StoreSystemEnumList.cshtml")]
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
#nullable restore
#line 1 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\StoreSystemEnumList.cshtml"
using ERPv1.ERP.CurrentAssetModules.Inventory.Model.Main;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb8b8eebb4e80c24d92e6dde721ec6f42249f64", @"/Views/Shared/EditorTemplates/StoreSystemEnumList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296e1f1e7e985af1e596c25ff18c1e05b69fb24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_StoreSystemEnumList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreSystemEnum>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\StoreSystemEnumList.cshtml"
   
    var option = ERPv1.Infrastructure.Extensions.EnumExtension.GetEnumSelectList<StoreSystemEnum>().Where(x=>x.Text !="Credit");

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\StoreSystemEnumList.cshtml"
   
    var htmlAtt = ViewData["htmlAtt"] ?? new { };

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Views\Shared\EditorTemplates\StoreSystemEnumList.cshtml"
Write(Html.DropDownList("",option,htmlAtt));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreSystemEnum> Html { get; private set; }
    }
}
#pragma warning restore 1591
