#pragma checksum "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Vendor_Performance_Filter), @"mvc.1.0.view", @"/Views/Vendor/Vendor_Performance_Filter.cshtml")]
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
#line 1 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using GMTVendorEvaluationWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2f0ee4d82a97c4b23e85d69d813f54c846f45b", @"/Views/Vendor/Vendor_Performance_Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef16c19e226af14357f195132318f0aad213b63", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendor_Vendor_Performance_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GMTVendorEvaluationWebApp.ViewModels.VendorEvaluation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
  
    ViewData["Title"] = "Vendor_Performance_Filter";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b6398", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 518, "\"", 528, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 555, "\"", 565, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b7326", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b8425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b9524", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b10623", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b11723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- Ionicons -->

    <style>
        /*#chart_container {
                width: 800px;
                height: 400px;
                border: 1px solid #ddd;
                padding: 1px;
                border-radius: 4px;
            }*/

        * {
            margin: 0;
            padding: 0;
            font-family: sans-serif;
        }

        .chartMenu {
            width: 30vw;
            height: 40px;
            background: #1A1A1A;
            color: rgba(255, 26, 104, 1);
        }

            .chartMenu p {
                padding: 10px;
                font-size: 20px;
            }

        .chartCard {
            width: 35vw;
            min-height: calc(50vh - 15px);
            display: flex;
            align-items: center;
            display: flex;
            text-align: center;
            padding-top: 30px;
            /*margin-left: auto;
                margin-right: auto;*/
        }

        .chartBox {
            width: 1");
                WriteLiteral(@"000px;
            padding: 20px;
            border-radius: 20px;
            border: solid 3px rgba(255, 26, 104, 1);
            background: white;
        }


        .content-wrapper {
            min-height: calc(100vh - 56px);
            padding-top: 4rem;
            overflow-x: hidden;
            background: transparent;
        }

        .info-box {
            display: block;
            min-height: 90px;
            background: #fff;
            width: 400px;
            box-shadow: 0 1px 1px rgba(0, 0, 0, 0.1);
            border-radius: 2px;
            margin-bottom: 15px;
        }

            .info-box small {
                font-size: 14px;
            }

            .info-box .progress {
                background: rgba(0, 0, 0, 0.2);
                margin: 5px -10px 5px -10px;
                height: 2px;
            }

                .info-box .progress,
                .info-box .progress .progress-bar {
                    border-radius: 0;
 ");
                WriteLiteral(@"               }

                    .info-box .progress .progress-bar {
                        background: #fff;
                    }

        .info-box-icon {
            border-top-left-radius: 2px;
            border-top-right-radius: 0;
            border-bottom-right-radius: 0;
            border-bottom-left-radius: 2px;
            display: block;
            float: left;
            height: 90px;
            width: 90px;
            text-align: center;
            font-size: 45px;
            line-height: 90px;
            background: #6CC785;
        }

            .info-box-icon > img {
                max-width: 100%;
            }

        .info-box-content {
            padding: 5px 10px;
            margin-left: 90px;
        }

        .info-box-number {
            display: block;
            font-weight: bold;
            font-size: 18px;
        }

        .progress-description,
        .info-box-text {
            display: block;
            font-si");
                WriteLiteral(@"ze: 14px;
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
        }

        .info-box-text {
            text-transform: uppercase;
        }

        .info-box-more {
            display: block;
        }

        .progress-description {
            margin: 0;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b2f0ee4d82a97c4b23e85d69d813f54c846f45b17144", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3 col-sm-6 col-xs-12"">
            <div class=""info-box"">
                <span class=""info-box-icon bg-aqua""><i class=""ion ion-ios-gear-outline""></i></span>
                <div class=""info-box-content"">
                    <span class=""info-box-text"">Vendors</span>
                    <span class=""info-box-number"">");
#nullable restore
#line 169 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                             Write(ViewData["vendor_count"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <div class=""col-md-3 col-sm-6 col-xs-12"">
            <div class=""info-box"">
                <span style=""background: #9A75FE"" class=""info-box-icon bg-red""><i class=""ion ion-ios-gear-outline""></i></span>
                <div class=""info-box-content"">
                    <span class=""info-box-text"">Products/Services</span>
                    <span class=""info-box-number"">");
#nullable restore
#line 181 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                             Write(ViewData["product_count"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <!-- fix for small devices only -->
        <div class=""clearfix visible-sm-block""></div>
        <div class=""col-md-3 col-sm-6 col-xs-12"">
            <div class=""info-box"">
                <span style=""background: #4EBCE5;"" class=""info-box-icon bg-green""><i class=""ion ion-ios-cart-outline""></i></span>
                <div class=""info-box-content"">
                    <span class=""info-box-text"">Departments</span>
                    <span class=""info-box-number"">");
#nullable restore
#line 195 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                             Write(ViewData["department_count"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <!-- /.col -->
    </div>
    <div>
        <div class=""chartCard"">
            <div class=""chartBox"">
                <p>Top 5 Performing Vendors between ");
#nullable restore
#line 207 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                               Write(ViewBag.START);

#line default
#line hidden
#nullable disable
                WriteLiteral(" and ");
#nullable restore
#line 207 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                                                  Write(ViewBag.END);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <canvas id=\"mychart\">\r\n                </canvas>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <hr />\r\n\r\n\r\n    <h1>Vendor Performance Table</h1>\r\n    <h2>Date Range: ");
#nullable restore
#line 218 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
               Write(ViewBag.START);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -- ");
#nullable restore
#line 218 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                                 Write(ViewBag.END);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
    <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search.."" title=""Type in a name"">
    <table class=""table table-striped"" id=""myTable"">
        <thead>
            <tr>
                <th>
                    Vendor Name
                </th>
                <th>
                    Number of Product/Service Evaluated
                </th>
                <th>
                    ");
#nullable restore
#line 230 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
               Write(Html.DisplayNameFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Grade\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 238 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 242 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 245 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NumberOfProducts));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 248 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Percentage));

#line default
#line hidden
#nullable disable
                WriteLiteral("%\r\n                    </td>\r\n\r\n");
#nullable restore
#line 251 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                      

                        if (item.Percentage >= 80 && item.Percentage <= 100)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"background-color:green; color: white;\">\r\n                                GREAT\r\n                            </td>\r\n");
#nullable restore
#line 258 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                        }

                        else if (item.Percentage >= 56 && item.Percentage <= 79)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"background-color:blue; color:white;\">\r\n                                GOOD\r\n                            </td>\r\n");
#nullable restore
#line 265 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                        }

                        else if (item.Percentage >= 46 && item.Percentage <= 55)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"background-color:gold; color:white;\">\r\n                                WATCHLIST\r\n                            </td>\r\n");
#nullable restore
#line 272 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                        }
                        else if (item.NumberOfProducts == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>\r\n                                Vendor yet to be evaluated\r\n                            </td>\r\n");
#nullable restore
#line 278 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"background-color:indianred; color: white;\">\r\n                                REPLACE\r\n                            </td>\r\n");
#nullable restore
#line 284 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                        }


#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 287 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                </td>\r\n");
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 296 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <hr />\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n</html>\r\n\r\n<script>\r\n        var percentArray = ");
#nullable restore
#line 313 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                      Write(Html.Raw(Json.Serialize(ViewBag.PER)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        var vendors = ");
#nullable restore
#line 314 "C:\Users\taofeeal\Downloads\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance_Filter.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.VENDORS)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        var ctx = $(""#mychart"");
        var bar = new Chart(ctx, {
            type: ""bar"",
            data: {
                labels: vendors,
                datasets: [{
                    label: ""Vendor Performance"",
                    data: percentArray,
                    backgroundColor: [""#3e95cd"", ""#8e5ea2"", ""#3cba9f"", ""#e8c3b9"", ""#c45850""],
                    //backgroundColor: [
                    //    ""rgba(74,25,92)"",
                    //    ""rgba(74,25,92)"",
                    //    ""rgba(74,25,92)"",
                    //    ""rgba(74,25,92)"",
                    //    ""rgba(74,25,92)"",

                    //    ],
                    borderColor: [""rgb(242,266,54)"", ""rgb(142,65,72)"", ""rgb(74,25,92)""],
                    //borderWidth: 1
                }]

            },

            options: {
                mainAspectRatio: false,
                scales: { xAxes: [{ ticks: { beginAtZero: true } }] },
                legend: { display: false },
     ");
            WriteLiteral(@"           plugins: {
                    title: {
                        display: true,
                        text: 'Vendor Performance Chart'
                    }
                }

            }

        });

        $(document).ready(function () {
            var mainTable;

            mainTable = $('.table').DataTable({
                ""lengthChange"": false,
                ""info"": false,
                ""searching"": true,
                ""dom"": 'lrtip',
                ""scrollX"": false
            });

            $('#mainSearch').keyup(function () {
                mainTable.search($(this).val()).draw();
            })

        });

        function myFunction() {

            // Declare variables
            var input = document.getElementById(""myInput"");
            var filter = input.value.toUpperCase();
            var table = document.getElementById(""myTable"");
            var trs = table.tBodies[0].getElementsByTagName(""tr"");

            // Loop through f");
            WriteLiteral(@"irst tbody's rows
            for (var i = 0; i < trs.length; i++) {

                // define the row's cells
                var tds = trs[i].getElementsByTagName(""td"");

                // hide the row
                trs[i].style.display = ""none"";

                // loop through row cells
                for (var i2 = 0; i2 < tds.length; i2++) {

                    // if there's a match
                    if (tds[i2].innerHTML.toUpperCase().indexOf(filter) > -1) {

                        // show the row
                        trs[i].style.display = """";

                        // skip to the next row
                        continue;

                    }
                }
            }

        }
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GMTVendorEvaluationWebApp.ViewModels.VendorEvaluation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
