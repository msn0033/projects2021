#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21d247445b5f6f6ac6b4d50fb942960f417f2c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Expenditure_Views_Supplier_NewPurchase), @"mvc.1.0.view", @"/Areas/Expenditure/Views/Supplier/NewPurchase.cshtml")]
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
#line 3 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21d247445b5f6f6ac6b4d50fb942960f417f2c6d", @"/Areas/Expenditure/Views/Supplier/NewPurchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2e40d160bdaf5ed04154bf1b50f92aed15d791", @"/Areas/Expenditure/Views/_ViewImports.cshtml")]
    public class Areas_Expenditure_Views_Supplier_NewPurchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERP.PurchasesModule.ViewModel.PurchaseContainer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "قائمة الاخطاء", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-back-ground", "bg-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "text-white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("addational-class", "fa-edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "بيانات المورد", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "تفاصيل المشتريات ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "بيانات الفاتورة", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout/knockout-3.5.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout.mapping/knockout.mapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/App/PurchaseVM.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ERPv1.TagHelpers.Card __ERPv1_TagHelpers_Card;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
   string data = JsonConvert.SerializeObject(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
  
    ViewData["Title"] = "NewPurchase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d8941", async() => {
                WriteLiteral("\r\n    <div data-bind=\"visible:IsMessageAreaVisible\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d9263", async() => {
                    WriteLiteral("\r\n            <ul data-bind=\"foreach:Messages\">\r\n                <li class=\"alert-danger\" data-bind=\"text:$data\"></li>\r\n            </ul>\r\n\r\n        ");
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
                WriteLiteral("\r\n    </div>\r\n    <div data-bind=\"visible:IsWaitingAreaVisible\" class=\"preload fa fa-spin fa-spinner\" style=\"font-size:150px\">\r\n\r\n    </div>\r\n    <div data-bind=\"visible:IsDetailAreaVisible\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d11302", async() => {
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
                        </div>");
                    WriteLiteral("\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        ");
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d14158", async() => {
                    WriteLiteral(@"

            <table class=""table table-bordered table-striped table-hover table-sm"">
                <thead>
                    <tr>
                        <th>المنتج</th>
                        <th>الكمية الحالية </th>
                        <th>الكمية</th>
                        <th>السعر</th>
                        <th>المجموع</th>
                        <th>سريال نبر</th>
                        <th>
                            <button class=""btn btn-primary"" data-bind=""click:AddNewItem"">
                                <i class=""fa fa-plus-circle""></i>
                            </button>
                        </th>
                    </tr>
                </thead>
                <tbody data-bind=""foreach:PurchasesDetails"">

                    <tr>
                        <td>
                            ");
#nullable restore
#line 73 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
                       Write(Html.Editor("StoreItemId", "StoreItems", new { htmlAtt = new { @data_bind = "value:StoreItemId, event:{change:ChangeItem}", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </td>
                        <td><span data-bind=""text:CurrentQTY""></span></td>
                        <td><input class=""form-control"" type=""text"" data-bind=""value:QTY,event:{change:$parent.ApplyVAT}"" /></td>
                        <td><input class=""form-control"" type=""text"" data-bind=""value:UnitPrice,event:{change:$parent.ApplyVAT}"" /></td>
                        <td><span type=""text"" data-bind=""text:Total""></span></td>
                        <td><textarea class=""form-control"" rows=""1"" cols=""3"" data-bind=""value:SN""></textarea></td>
                        <td><button class=""btn btn-danger"" data-bind=""click:$parent.RemoveItem""><i class=""fa fa-minus-circle""></i></button></td>
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d17918", async() => {
                    WriteLiteral(@"
        <div class=""container"">
            <div class=""row"">
                <div class=""col-4"">

                    <div class=""form-group"">
                        <lable>الإجمالي</lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:PurchaseSummary.TotalAmount"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>تاريخ الفاتورة</lable>
                        <input class=""form-control dateSamll"" data-bind=""value:PurchaseSummary.PurchaseDate"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>رقم الفاتورة</lable>
                        <input class=""form-control"" data-bind=""value:PurchaseSummary.InvoiceNum"" />
                    </div>
                </div>
            </div>
        </div>

        <div class=""");
                    WriteLiteral(@"container"">
            <div class=""row"">
                <div class=""col-4"">

                    <div class=""form-group"">
                        <lable>ضريبة</lable>
                        <input type=""checkbox"" class=""form-control"" data-bind=""checked:PurchaseSummary.IsVAT,event:{change:ApplyVAT}"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>اجمالي الضريبة </lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:PurchaseSummary.VATAmount"" />
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""form-group"">
                        <lable>الاجمالي شامل الضريبة</lable>
                        <input class=""form-control"" disabled=""disabled"" data-bind=""value:PurchaseSummary.TotalAmountWithVAT"" />
                    </div>
                </div>
            </div>
  ");
                    WriteLiteral("      </div>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-2\">\r\n\r\n                    <div class=\"form-group\">\r\n                        <lable>العملة</lable>\r\n                        ");
#nullable restore
#line 140 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
                   Write(Html.EditorFor(x => x.PurchaseSummary.CurrencyId, "CurrencyList", new { htmlAtt = new { @class = "form-control", data_bind = "value:PurchaseSummary.CurrencyId" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    <div class=\"form-group\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d21205", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 145 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PurchaseSummary.RepositoryId);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 146 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
                   Write(Html.EditorFor(x => x.PurchaseSummary.RepositoryId, "RepositoryList", new { htmlAtt = new { @class = "form-control",data_bind= "value:PurchaseSummary.RepositoryId" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d23323", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 147 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PurchaseSummary.RepositoryId);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </div>
                </div>

                <div class=""col-2"">
                    <div class=""form-group"">
                        <lable>أرفاق صورة </lable>
                        <input type=""file"" class=""form-control-file"" id=""InvoiceFile"" />
                    </div>
                </div>
                <div class=""col-5"">
                    <div class=""form-group"">
                        <lable> اضافة تفاصيل</lable>
                        <textarea class=""form-control"" data-bind=""value:PurchaseSummary.Description""></textarea>
                    </div>
                </div>
            </div>
        </div>

                <div class=""card-footer text-center"">
                    <button class=""btn btn-primary"" data-bind=""click:Save"">حـفـظ</button>
                </div>

");
                }
                );
                __ERPv1_TagHelpers_Card = CreateTagHelper<global::ERPv1.TagHelpers.Card>();
                __tagHelperExecutionContext.Add(__ERPv1_TagHelpers_Card);
                __ERPv1_TagHelpers_Card.Title = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
                WriteLiteral("\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d28613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d29718", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d247445b5f6f6ac6b4d50fb942960f417f2c6d30823", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#nullable restore
#line 179 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
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
                WriteLiteral("\r\n        <script>\r\n            var Purchase = new PurchaseVM(");
#nullable restore
#line 181 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\Expenditure\Views\Supplier\NewPurchase.cshtml"
                                     Write(Html.Raw(data));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n            ko.applyBindings(Purchase);\r\n        </script>\r\n    ");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP.PurchasesModule.ViewModel.PurchaseContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
