#pragma checksum "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b883e5536d642e619ef784c330acff7e8f73ba49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluation_Create), @"mvc.1.0.view", @"/Views/Evaluation/Create.cshtml")]
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
#line 1 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b883e5536d642e619ef784c330acff7e8f73ba49", @"/Views/Evaluation/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef16c19e226af14357f195132318f0aad213b63", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluation_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GMTVendorEvaluationWebApp.ViewModels.CriteriaOptions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
      
        ViewData["Title"] = "Create";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>VENDOR/SUPPLIER EVALUATION FORM</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
      
        var vendoinfo = ViewData["vendor"] as Vendor;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered"">

            <thead>
                <tr>
                    <th colspan=""4"" style=""text-align:center"">Vendor/Supplier Information</th>
                </tr>
            </thead>
            <tbody>

                <tr>
                    <td>
                        <strong>Company Name:</strong>
                    </td>
                    <td>
                        ");
#nullable restore
#line 26 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.company_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <strong>Type of Business:</strong>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.type_of_business);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <strong>Contact Person: </strong>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.contact_person);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <strong>Phone:</strong>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        <strong>Company Address:</strong>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.company_address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <strong>Email:</strong>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                   Write(vendoinfo.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n");
            WriteLiteral("\r\n\r\n    <h4>Admin Evaluation</h4>\r\n    <hr />\r\n\r\n");
#nullable restore
#line 73 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
      
        var dd = ViewData["product"] as Product_Service;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>\r\n            ");
#nullable restore
#line 76 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
       Write(dd.product_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h4>\r\n");
            WriteLiteral("\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b883e5536d642e619ef784c330acff7e8f73ba499064", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b883e5536d642e619ef784c330acff7e8f73ba499338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
                                WriteLiteral(ViewData["productid"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 84 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
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
                <h6>Competitiveness of Costing</h6>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""1"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Very Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""2"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""3"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                  ");
                WriteLiteral(@"      Somewhat Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""4"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Somewhat Satisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""5"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Satisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""6"" name=""competitiveness_of_costing"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefa");
                WriteLiteral(@"ult2"">
                        Very Satisfied
                    </label>
                </div>
                <br />
                <h6>Statutory permits and rules</h6>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""1"" name=""staturory_permits"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Very Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""2"" name=""staturory_permits"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""3"" name=""staturory_permits"" id=""flexRadioDefault2"">");
                WriteLiteral(@"
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Somewhat Dissatisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""4"" name=""staturory_permits"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Somewhat Satisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""5"" name=""staturory_permits"" id=""flexRadioDefault2"">
                    <label class=""form-check-label"" for=""flexRadioDefault2"">
                        Satisfied
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" value=""6"" name=""staturory_permits"" id=""flexRadioDefault2"">");
                WriteLiteral(@"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b883e5536d642e619ef784c330acff7e8f73ba4917761", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
#line 206 "C:\Users\taofeeal\Documents\gmt-vendor-evaluator\Views\Evaluation\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GMTVendorEvaluationWebApp.ViewModels.CriteriaOptions> Html { get; private set; }
    }
}
#pragma warning restore 1591
