#pragma checksum "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d73b5d1e45da232c0320cac67b58d658f2c26d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CurrentNP_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CurrentNP/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d73b5d1e45da232c0320cac67b58d658f2c26d2", @"/Views/Shared/Components/CurrentNP/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296e1f1e7e985af1e596c25ff18c1e05b69fb24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CurrentNP_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ERPv1.ERP.CurrentLiabilitiesModules.NotesPayableModule.ViewModel.NPDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", " شيكات تحت الصرف ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-back-ground", "bg-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "text-white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("addational-class", "fa-edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::ERPv1.TagHelpers.Card __ERPv1_TagHelpers_Card;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d73b5d1e45da232c0320cac67b58d658f2c26d24352", async() => {
                WriteLiteral(@"

        <table class=""table table-bordered table-striped table-hover table-sm"">
            <thead>
                <tr>
                    <th>أسم المورد</th>
                    <th>رقم الشيك</th>
                    <th>المبلغ</th>
                    <th>العملة</th>
                    <th>تاريخ الاستحقاق</th>
                    <th>البنك</th>
                   



                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                 foreach (var item in Model)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td><span>");
#nullable restore
#line 25 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.SupplierName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 26 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.ChkNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 27 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.AmountForgin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 28 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.CurrencyAbbrev);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 29 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.DueDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 30 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"
                             Write(item.BankName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                       \r\n\r\n                        <!--BankAccountNum-->\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 36 "D:\PROJECT\ERP\ERPv1\ERPv1\Views\Shared\Components\CurrentNP\Default.cshtml"

                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
            }
            );
            __ERPv1_TagHelpers_Card = CreateTagHelper<global::ERPv1.TagHelpers.Card>();
            __tagHelperExecutionContext.Add(__ERPv1_TagHelpers_Card);
            __ERPv1_TagHelpers_Card.Title = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __ERPv1_TagHelpers_Card.HeaderBackGround = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __ERPv1_TagHelpers_Card.TextColor = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __ERPv1_TagHelpers_Card.AddationalClass = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ERPv1.ERP.CurrentLiabilitiesModules.NotesPayableModule.ViewModel.NPDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
