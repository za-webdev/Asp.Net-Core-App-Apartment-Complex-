#pragma checksum "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f39b6bbb4a90e0760f9437538104fc7a55a742c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\_ViewImports.cshtml"
using DemoCoreApp;

#line default
#line hidden
#line 2 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\_ViewImports.cshtml"
using DemoCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f39b6bbb4a90e0760f9437538104fc7a55a742c", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2ade1728dab262b615859e8ec3d2aa5b2aea41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VehicleInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(170, 301, true);
            WriteLiteral(@"
<h2>All Vehicles</h2>
    <table border=""1"">
       <tr>
           <td>
               ID
           </td>
           <td>
               Model
           </td>
           <td>
               Make
           </td>
           <td>
               Action
           </td>
       </tr>
");
            EndContext();
#line 26 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
             foreach (var v in Model)
            {

#line default
#line hidden
            BeginContext(525, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(574, 11, false);
#line 30 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
           Write(v.VehicleId);

#line default
#line hidden
            EndContext();
            BeginContext(585, 61, true);
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(647, 7, false);
#line 36 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
           Write(v.Model);

#line default
#line hidden
            EndContext();
            BeginContext(654, 59, true);
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(714, 6, false);
#line 41 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
           Write(v.Make);

#line default
#line hidden
            EndContext();
            BeginContext(720, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 777, "\"", 817, 2);
            WriteAttributeValue("", 784, "/Vehicle/VehicleInfo/", 784, 21, true);
#line 44 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
WriteAttributeValue("", 805, v.VehicleId, 805, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(818, 29, true);
            WriteLiteral(">View</a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 847, "\"", 914, 1);
#line 45 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
WriteAttributeValue("", 854, Url.Action("VehicleInfo","Vehicle",new {vid= v.VehicleId }), 854, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 47, true);
            WriteLiteral(" class=\"btn-default\">Show</a>\r\n                ");
            EndContext();
            BeginContext(962, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7f469538af436e86cf3da9883c385e", async() => {
                BeginContext(1068, 8, true);
                WriteLiteral(" Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
                                                                        WriteLiteral(v.VehicleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1080, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Home\About.cshtml"
            }

#line default
#line hidden
            BeginContext(1131, 18, true);
            WriteLiteral("\r\n    </table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
