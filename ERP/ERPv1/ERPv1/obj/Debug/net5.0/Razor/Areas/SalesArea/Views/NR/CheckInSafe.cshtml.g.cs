#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d689be2a88c05839bcb8261acd8aadb7df0a6eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SalesArea_Views_NR_CheckInSafe), @"mvc.1.0.view", @"/Areas/SalesArea/Views/NR/CheckInSafe.cshtml")]
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
#line 1 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\_ViewImports.cshtml"
using ERPv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\_ViewImports.cshtml"
using ERPv1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d689be2a88c05839bcb8261acd8aadb7df0a6eb3", @"/Areas/SalesArea/Views/NR/CheckInSafe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2e40d160bdaf5ed04154bf1b50f92aed15d791", @"/Areas/SalesArea/Views/_ViewImports.cshtml")]
    public class Areas_SalesArea_Views_NR_CheckInSafe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERPv1.ERP.CurrentAssetModules.Checks.ViewModel.ChecksInSafe.CheckInSafeContainerVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout/knockout-3.5.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout.mapping/knockout.mapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/APP/CheckInSafe.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
  
    ViewData["Title"] = "CheckInSafe";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
   string data = JsonConvert.SerializeObject(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d689be2a88c05839bcb8261acd8aadb7df0a6eb35981", async() => {
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-header bg-primary"">
            <b class=""text-white"">
                <span class=""fa fa-list""></span>&nbsp; شيكات في الخزنة
            </b>
        </div>
        <div class=""card-body"">
            <table class=""table table-bordered table-striped table-hover dataTable"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>

                        </th>
                        <th>
                            اسم العميل
                        </th>

                        <th>
                            رقم الشيك
                        </th>
                        <th>
                            مبلغ الشيك
                        </th>
                        <th>
                            مبلغ الشيك بالعملة
                        </th>
                        <th>
                            العملة
                        </th>
                        <th>
                  ");
                WriteLiteral(@"          تاريخ الأستحقاق
                        </th>
                        <th>
                            علي بنك
                        </th>
                        <th>
                            حالة الشيك
                        </th>

                        <th>
                            المدفوع
                        </th>
                        <th></th>


                    </tr>
                </thead>
                <tbody data-bind=""foreach: CheckInSafeDetailsVM"">
                    <tr>
                        <td>
                            <input type=""checkbox"" data-bind=""checked:Selected,enable:Paid()==0"" />
                        </td>
                        <td>
                            <span data-bind=""text: ClientName"" />
                        </td>
                        <td>
                            <span data-bind=""text: CheckNum"" />
                        </td>
                        <td>
                            <span da");
                WriteLiteral(@"ta-bind=""text: CheckAmount"" />
                        </td>
                        <td>
                            <span data-bind=""text: CheckAmountForiegn"" />
                        </td>
                        <td>
                            <span data-bind=""text: CurrencyAbbr"" />
                        </td>
                        <td>
                            <span data-bind=""text: DueDate"" />
                        </td>
                        <td>
                            <span data-bind=""text: OrginalBank"" />
                        </td>
                        <td>
                            <span data-bind=""text: CheckStatus"" />
                        </td>
                        <td>
                            <span data-bind=""text: Paid"" />
                        </td>
                        <td>
                            <a class=""btn btn-primary"" data-bind=""attr:{href:'/SalesArea/NR/CollectCashCheck/'+CheckNum()}"">تحصيل نقدي</a>
                    ");
                WriteLiteral(@"    </td>
                    </tr>

                </tbody>

            </table>


        </div>

    </div>
    <div class=""card"">
        <div class=""card-header bg-primary"">
            <b class=""text-white"">
                <span class=""fa fa-list"">&nbsp; تفاصيل الحافظة</span>
            </b>
        </div>
        <div class=""card-body"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <label for=""SearchCriteria.UnitName"">اسم الحافظة</label>
                            ");
#nullable restore
#line 114 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
                       Write(Html.EditorFor(x => x.HafzaDetailsVM.HafzaName, new
                       {
                           htmlAttributes = new
                           {
                               @data_bind = "value:HafzaDetailsVM.HafzaName",
                               @class = "form-control"
                           }
                       }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <label for=""SearchCriteria.UnitName"">اختار البنك</label>
                            ");
#nullable restore
#line 127 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
                       Write(Html.EditorFor(x => x.HafzaDetailsVM.BankAccNum, "BankAccountList", new
                       {
                           htmlAtt = new
                           {
                               @data_bind = "value:HafzaDetailsVM.BankAccNum",
                               @class = "form-control"
                           }
                       }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""SearchCriteria.UnitName"">تاريخ الحافظة</label>
                        <div class=""form-group"">

                            ");
#nullable restore
#line 141 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
                       Write(Html.EditorFor(x => x.HafzaDetailsVM.HafzaDate, new
                       {
                           htmlAttributes = new
                           {
                               @data_bind = "value:HafzaDetailsVM.HafzaDate",
                               @class = "form-control date"
                           }
                       }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card-footer text-center"">
            <button class=""btn btn-primary"" type=""button"" data-bind=""click:Save"">
                <i class=""fa fa-save""></i>&nbsp;
                حفظ
            </button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d689be2a88c05839bcb8261acd8aadb7df0a6eb314168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d689be2a88c05839bcb8261acd8aadb7df0a6eb315268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d689be2a88c05839bcb8261acd8aadb7df0a6eb316368", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 169 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
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
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        var NR = new ChecksInSafe(");
#nullable restore
#line 171 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\NR\CheckInSafe.cshtml"
                             Write(Html.Raw(data));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        ko.applyBindings(NR);\r\n    </script>\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERPv1.ERP.CurrentAssetModules.Checks.ViewModel.ChecksInSafe.CheckInSafeContainerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
