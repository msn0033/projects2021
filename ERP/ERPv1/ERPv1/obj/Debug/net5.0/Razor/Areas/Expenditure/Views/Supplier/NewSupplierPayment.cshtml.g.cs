#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "413a047e8bcd38183bc5519b15b4a20d46e5066e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Expenditure_Views_Supplier_NewSupplierPayment), @"mvc.1.0.view", @"/Areas/Expenditure/Views/Supplier/NewSupplierPayment.cshtml")]
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
#line 1 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\_ViewImports.cshtml"
using ERPv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\_ViewImports.cshtml"
using ERPv1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413a047e8bcd38183bc5519b15b4a20d46e5066e", @"/Areas/Expenditure/Views/Supplier/NewSupplierPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2e40d160bdaf5ed04154bf1b50f92aed15d791", @"/Areas/Expenditure/Views/_ViewImports.cshtml")]
    public class Areas_Expenditure_Views_Supplier_NewSupplierPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERPv1.ERP.PurchasesModule.ViewModel.SupplierPayment.SupplierPaymentContainer>
    {
        private global::AspNetCore.Areas_Expenditure_Views_Supplier_NewSupplierPayment.__Generated__SupplierPaymentMethodComponentsViewComponentTagHelper __SupplierPaymentMethodComponentsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "قائمة الاخطاء", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-back-ground", "bg-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "text-white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("addational-class", "fa-edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "بيانات المورد", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "تفاصيل الرصيد ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout/knockout-3.5.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout.mapping/knockout.mapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/App/SupplierPayment.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml"
   string data = JsonConvert.SerializeObject(Model);

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml"
  
    ViewData["Title"] = "SupplierPayment";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div data-bind=\"visible:IsMessageAreaVisible\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e7343", async() => {
                WriteLiteral("\r\n        <ul data-bind=\"foreach:Messages\">\r\n            <li class=\"alert-danger\" data-bind=\"text:$data\"></li>\r\n        </ul>\r\n\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n<div data-bind=\"visible:IsWaitingAreaVisible\" class=\"preload fa fa-spin fa-spinner\" style=\"font-size:150px\">\r\n\r\n</div>\r\n\r\n<div data-bind=\"visible:IsDetailAreaVisible\">\r\n    <!--بيانات المورد-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e9290", async() => {
                WriteLiteral(@"

        <div class=""container"">
            <div class=""row"">
                <div class=""col-4"">

                    <div class=""form-group"">
                        <lable>اسم المورد</lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:SupplierData.SupplierName"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>رقم التلفون</lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:SupplierData.Phone"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>الرصيد</lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:SupplierData.Balance"" />
                    </div>
                </div>
            </div>
        </div>

    ");
            }
            );
            __ERPv1_TagHelpers_Card = CreateTagHelper<global::ERPv1.TagHelpers.Card>();
            __tagHelperExecutionContext.Add(__ERPv1_TagHelpers_Card);
            __ERPv1_TagHelpers_Card.Title = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            WriteLiteral("\r\n    <!--تفاصيل الرصيد-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e11941", async() => {
                WriteLiteral(@"

        <table class=""table table-bordered table-striped table-hover table-sm"">
            <thead>
                <tr>
                    <th>العملة</th>
                    <th>الرصيد  </th>
                    <th>الرصيد بالعملة المحلية</th>
                    <th>سعر الصرف</th>

                </tr>
            </thead>
            <tbody data-bind=""foreach:SupplierBalanceDetails"">

                <tr style=""cursor:pointer"" data-bind=""click:$parent.SelectBalance,css:{selected:CurrencyId() ==$parent.SelectedBalance.CurrencyId()}"">

                    <td><span data-bind=""text:CurrencyAbbr""></span></td>

                    <td><span data-bind=""text:Amount""></span></td>

                    <td><span data-bind=""text:LocalAmount""></span></td>

                    <td><span data-bind=""text:Rate""></span></td>


                </tr>
            </tbody>
        </table>
    ");
            }
            );
            __ERPv1_TagHelpers_Card = CreateTagHelper<global::ERPv1.TagHelpers.Card>();
            __tagHelperExecutionContext.Add(__ERPv1_TagHelpers_Card);
            __ERPv1_TagHelpers_Card.Title = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            WriteLiteral("\r\n\r\n    <!--تفاصيل المدفوعات-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:supplier-payment-method-components", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e14489", async() => {
            }
            );
            __SupplierPaymentMethodComponentsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Expenditure_Views_Supplier_NewSupplierPayment.__Generated__SupplierPaymentMethodComponentsViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SupplierPaymentMethodComponentsViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e15632", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e16732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "413a047e8bcd38183bc5519b15b4a20d46e5066e17832", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 87 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        var SupplierPayment = new SupplierPaymentVM(");
#nullable restore
#line 89 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewSupplierPayment.cshtml"
                                               Write(Html.Raw(data));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        ko.applyBindings(SupplierPayment);\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERPv1.ERP.PurchasesModule.ViewModel.SupplierPayment.SupplierPaymentContainer> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:supplier-payment-method-components")]
        public class __Generated__SupplierPaymentMethodComponentsViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__SupplierPaymentMethodComponentsViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("SupplierPaymentMethodComponents", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                return args;
            }
        }
    }
}
#pragma warning restore 1591
