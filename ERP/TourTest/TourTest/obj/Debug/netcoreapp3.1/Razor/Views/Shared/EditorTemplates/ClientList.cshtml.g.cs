#pragma checksum "D:\PROJECT\ERP\TourTest\TourTest\Views\Shared\EditorTemplates\ClientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88a95b34b66c68992f5cb7b0341aa2b2b1491a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_ClientList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/ClientList.cshtml")]
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
#line 1 "D:\PROJECT\ERP\TourTest\TourTest\Views\_ViewImports.cshtml"
using TourTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECT\ERP\TourTest\TourTest\Views\_ViewImports.cshtml"
using TourTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88a95b34b66c68992f5cb7b0341aa2b2b1491a1", @"/Views/Shared/EditorTemplates/ClientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa49604b4b4c7b39f388e4b27744db145b3d41ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_ClientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PROJECT\ERP\TourTest\TourTest\Views\Shared\EditorTemplates\ClientList.cshtml"
   
    var client = _dbcontex.Clients.Select(x => new SelectListItem
    {
        Value = x.Id.ToString(),
        Text = x.NameClient
    }
    ).OrderBy(x => x.Text).ToList();

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PROJECT\ERP\TourTest\TourTest\Views\Shared\EditorTemplates\ClientList.cshtml"
   
    var htmlAttributes = ViewData["htmlAttributes"] ?? new { };

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\PROJECT\ERP\TourTest\TourTest\Views\Shared\EditorTemplates\ClientList.cshtml"
Write(Html.DropDownList("", client, "--اختار--", htmlAttributes));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public TourTest.Data.ApplicationDbContext _dbcontex { get; private set; }
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
