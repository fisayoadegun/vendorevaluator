#pragma checksum "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c301dd6c514672015f90e50c977c2692a06b6288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluation_Edit), @"mvc.1.0.view", @"/Views/Evaluation/Edit.cshtml")]
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
#line 1 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c301dd6c514672015f90e50c977c2692a06b6288", @"/Views/Evaluation/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eafde8e6fbec5f58289a4098e7eb94ebb7a3a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluation_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GMTVendorEvaluationWebApp.ViewModels.CriteriaOptions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
  
    ViewData["Title"] = "Admin_Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>VENDOR/SUPPLIER EVALUATION FORM</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
  
    var vendoinfo = ViewData["vendor"] as Vendor;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'some-page-wrapper\'>\r\n        <div class=\'row\'>\r\n            <div class=\'column\'>\r\n                <div class=\'blue-column\'>\r\n                    Company Name: ");
#nullable restore
#line 17 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                             Write(vendoinfo.company_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\'column\'>\r\n                <div class=\'green-column\'>\r\n                    Type of Business: ");
#nullable restore
#line 22 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                                 Write(vendoinfo.type_of_business);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\'some-page-wrapper\'>\r\n        <div class=\'row\'>\r\n            <div class=\'column\'>\r\n                <div class=\'blue-column\'>\r\n                    Contact Person: ");
#nullable restore
#line 31 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                               Write(vendoinfo.contact_person);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\'column\'>\r\n                <div class=\'green-column\'>\r\n                    Phone Number: ");
#nullable restore
#line 36 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                             Write(vendoinfo.phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\'some-page-wrapper\'>\r\n        <div class=\'row\'>\r\n            <div class=\'column\'>\r\n                <div class=\'blue-column\'>\r\n                    Company Address: ");
#nullable restore
#line 45 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                                Write(vendoinfo.company_address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\'column\'>\r\n                <div class=\'green-column\'>\r\n                    Email: ");
#nullable restore
#line 50 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                      Write(vendoinfo.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n<h4>Departmental Evaluation</h4>\r\n<hr />\r\n\r\n");
#nullable restore
#line 62 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
  
    var dd = ViewData["product"] as Product_Service;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>\r\n        ");
#nullable restore
#line 65 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
   Write(dd.product_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c301dd6c514672015f90e50c977c2692a06b62889100", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c301dd6c514672015f90e50c977c2692a06b62889370", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 71 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c301dd6c514672015f90e50c977c2692a06b628811052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                            WriteLiteral(ViewData["productid"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 72 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.productId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <h6>Timeliness</h6>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c301dd6c514672015f90e50c977c2692a06b628813493", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
                            WriteLiteral(ViewData["productid"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.productId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""1"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""2"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""3"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type");
                WriteLiteral(@"=""radio"" value=""4"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""5"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""6"" name=""timeliness"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Satisfied
                </label>
            </div>
            <br />
            <h6>Quality of products/Parts/Material/Service Provided</h6>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio");
                WriteLiteral(@""" value=""1"" name=""quality_of_products"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""2"" name=""quality_of_products"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""3"" name=""quality_of_products"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""4"" name=""quality_of_products"" id=""flexRadioDefault2"">
 ");
                WriteLiteral(@"               <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""5"" name=""quality_of_products"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""6"" name=""quality_of_products"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Satisfied
                </label>
            </div>
            <br />
            <h6>Presentation</h6>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""1"" name=""presentation"" id=""flexRadioDefault2"">
                <label clas");
                WriteLiteral(@"s=""form-check-label"" for=""flexRadioDefault2"">
                    Very Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""2"" name=""presentation"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""3"" name=""presentation"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""4"" name=""presentation"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Satisfied");
                WriteLiteral(@"
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""5"" name=""presentation"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""6"" name=""presentation"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Satisfied
                </label>
            </div>
            <br />
            <h6>After Sales/Support</h6>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""1"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Dissatisfied
                </label>
");
                WriteLiteral(@"            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""2"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""3"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Dissatisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""4"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Somewhat Satisfied
                </label>
            </div>
            <div class=""form-check"">
      ");
                WriteLiteral(@"          <input class=""form-check-input"" type=""radio"" value=""5"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Satisfied
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" value=""6"" name=""after_sales_support"" id=""flexRadioDefault2"">
                <label class=""form-check-label"" for=""flexRadioDefault2"">
                    Very Satisfied
                </label>
            </div>
            <br />
            <div class=""form-group"">
                <input type=""submit"" value=""Evaluate"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c301dd6c514672015f90e50c977c2692a06b628825667", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<style>
    /*.some-page-wrapper {
        margin: 15px;
        background-color: red;
    }*/

    .row {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        width: 100%;
    }

    .column {
        display: flex;
        flex-direction: column;
        flex-basis: 100%;
        flex: 1;
    }

    /*.blue-column {
        background-color: blue;
        height: 100px;
    }*/

    /*.green-column {
        background-color: green;
        height: 100px;
    }*/
</style>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 269 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Evaluation\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GMTVendorEvaluationWebApp.ViewModels.CriteriaOptions> Html { get; private set; }
    }
}
#pragma warning restore 1591
