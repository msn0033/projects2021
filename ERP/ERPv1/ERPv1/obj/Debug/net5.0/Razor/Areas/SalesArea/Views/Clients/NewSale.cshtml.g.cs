#pragma checksum "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SalesArea_Views_Clients_NewSale), @"mvc.1.0.view", @"/Areas/SalesArea/Views/Clients/NewSale.cshtml")]
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
#line 5 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4adee8eca27a27518c6cb9c9b1aa4ea826199f", @"/Areas/SalesArea/Views/Clients/NewSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2e40d160bdaf5ed04154bf1b50f92aed15d791", @"/Areas/SalesArea/Views/_ViewImports.cshtml")]
    public class Areas_SalesArea_Views_Clients_NewSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERPv1.ERP.SalesModule.ViewModel.SalesContainer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "قائمة الاخطاء", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-back-ground", "bg-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "text-white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("addational-class", "fa-edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "بيانات العميل", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "تفاصيل المبيعات ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "بيانات الفاتورة", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout/knockout-3.5.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/knockout.mapping/knockout.mapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/App/SaleVM.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
   string data = JsonConvert.SerializeObject(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
  
    ViewData["Title"] = "NewPurchase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f8274", async() => {
                WriteLiteral("\r\n    <div data-bind=\"visible:IsMessageAreaVisible\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f8596", async() => {
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
                WriteLiteral("\r\n    </div>\r\n    <div data-bind=\"visible:IsWaitingAreaVisible\" class=\"preload fa fa-spin fa-spinner\" style=\"font-size:150px\">\r\n\r\n    </div>\r\n\r\n    <div data-bind=\"visible:IsDetailAreaVisible\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f10639", async() => {
                    WriteLiteral(@"
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>اسم العميل</lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:ClientData.ClientName"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>رقم التلفون</lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:ClientData.Phone"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>الرصيد</lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:ClientData.Balance"" />
                        </div>
           ");
                    WriteLiteral("         </div>\r\n                </div>\r\n            </div>\r\n\r\n        ");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f13482", async() => {
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
                <tbody data-bind=""foreach:SalesItemDetails"">
                    <tr>
                        <td>
                            ");
#nullable restore
#line 72 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
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
");
                    WriteLiteral("                        <td><button class=\"btn btn-danger\" data-bind=\"click:$parent.RemoveItem\"><i class=\"fa fa-minus-circle\"></i></button></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        ");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f17154", async() => {
                    WriteLiteral(@"
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-4"">

                        <div class=""form-group"">
                            <lable>الإجمالي</lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:SalesSummary.Amount"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>تاريخ الفاتورة</lable>
                            <input class=""form-control dateSamll"" data-bind=""value:SalesSummary.InvoiceDate"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                           
                        </div>
                    </div>
                </div>
            </div>

            <div class=""container"">
                <div class=""row"">
     ");
                    WriteLiteral(@"               <div class=""col-4"">

                        <div class=""form-group"">
                            <lable>ضريبة</lable>
                            <input type=""checkbox"" class=""form-control"" data-bind=""checked:SalesSummary.IsVAT,event:{change:ApplyVAT}"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>اجمالي الضريبة </lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:SalesSummary.VATAmount"" />
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable>الاجمالي شامل الضريبة</lable>
                            <input class=""form-control"" disabled=""disabled"" data-bind=""value:SalesSummary.TotalWithVAT"" />
                        </div>
                    </div>
              ");
                    WriteLiteral(@"  </div>
            </div>

            <div class=""container"">
                <div class=""row"">
                    <div class=""col-4"">

                        <div class=""form-group"">
                            <lable>العملة</lable>
                            ");
#nullable restore
#line 138 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
                       Write(Html.EditorFor(x => x.SalesSummary.CurrencyId, "CurrencyList", new { htmlAtt = new { @class = "form-control", data_bind = "value:SalesSummary.CurrencyId" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                           
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group"">
                            <lable> اضافة تفاصيل</lable>
                            <textarea class=""form-control"" data-bind=""value:SalesSummary.Description""></textarea>                         
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
                __ERPv1_TagHelpers_Card.Title = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f23877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f24977", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b4adee8eca27a27518c6cb9c9b1aa4ea826199f26078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 168 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n            var Sale = new SaleVM(");
#nullable restore
#line 170 "E:\PROJECT\Web\ERP\ERPv1\ERPv1\Areas\SalesArea\Views\Clients\NewSale.cshtml"
                             Write(Html.Raw(data));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n            ko.applyBindings(Sale);\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERPv1.ERP.SalesModule.ViewModel.SalesContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
