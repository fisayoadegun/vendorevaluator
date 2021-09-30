#pragma checksum "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f40e0237771163bcce82f078a2ef5b1098300da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Vendor_Performance), @"mvc.1.0.view", @"/Views/Vendor/Vendor_Performance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f40e0237771163bcce82f078a2ef5b1098300da", @"/Views/Vendor/Vendor_Performance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eafde8e6fbec5f58289a4098e7eb94ebb7a3a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendor_Vendor_Performance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GMTVendorEvaluationWebApp.ViewModels.VendorEvaluation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
  
    ViewData["Title"] = "Vendor_Performance";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Vendor Performance Evaluation</h1>

<table class=""table table-bordered"">
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
#line 19 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
           Write(Html.DisplayNameFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Grade\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberOfProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
               Write(Html.DisplayFor(modelItem => item.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n                </td>\r\n");
#nullable restore
#line 39 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
                  
                    if (item.Percentage >= 80 && item.Percentage <= 100)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            GREAT\r\n                        </td>\r\n");
#nullable restore
#line 45 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
                    }

                    else if (item.Percentage >= 56 && item.Percentage <= 79)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            GOOD\r\n                        </td>\r\n");
#nullable restore
#line 52 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
                    }

                    else if (item.Percentage >= 46 && item.Percentage <= 55)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            WATCHLIST\r\n                        </td>\r\n");
#nullable restore
#line 59 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            REPLACE\r\n                        </td>\r\n");
#nullable restore
#line 65 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
                    }


                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\ADEGUN FISAYO\Documents\gmt-vendor-evaluator\Views\Vendor\Vendor_Performance.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
