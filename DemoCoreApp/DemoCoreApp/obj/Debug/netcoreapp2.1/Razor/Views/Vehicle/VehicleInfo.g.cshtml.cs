#pragma checksum "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f214071e947eb915f017513392ea1d105a90290d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_VehicleInfo), @"mvc.1.0.view", @"/Views/Vehicle/VehicleInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/VehicleInfo.cshtml", typeof(AspNetCore.Views_Vehicle_VehicleInfo))]
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
#line 3 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f214071e947eb915f017513392ea1d105a90290d", @"/Views/Vehicle/VehicleInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2ade1728dab262b615859e8ec3d2aa5b2aea41", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_VehicleInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoCoreApp.ViewModels.OwnerVehicleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VehicleInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 25, true);
            WriteLiteral("\r\n<h1>Vehicle Info</h1>\r\n");
            EndContext();
            BeginContext(394, 18, true);
            WriteLiteral("<div>\r\n    Model: ");
            EndContext();
            BeginContext(413, 19, false);
#line 20 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
      Write(Model.Vehicle.Model);

#line default
#line hidden
            EndContext();
            BeginContext(432, 27, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Make: ");
            EndContext();
            BeginContext(460, 18, false);
#line 23 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
     Write(Model.Vehicle.Make);

#line default
#line hidden
            EndContext();
            BeginContext(478, 42, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Registration Number: ");
            EndContext();
            BeginContext(521, 32, false);
#line 26 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
                    Write(Model.Vehicle.RegistrationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(553, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
 if (Context.Session.GetInt32("ownerId") != null && Context.Session.GetInt32("ownerId") == Model.Vehicle.VehicleOwnerId)
{


#line default
#line hidden
            BeginContext(692, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(711, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e53c3bf90474ab8bfc739038b3b5495", async() => {
                BeginContext(821, 5, true);
                WriteLiteral(" Edit");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
                                                        WriteLiteral(Model.Vehicle.VehicleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(830, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
}

#line default
#line hidden
            BeginContext(847, 43, true);
            WriteLiteral("\r\n<h1>Owner Info</h1>\r\n\r\n<div>\r\n    Model: ");
            EndContext();
            BeginContext(891, 21, false);
#line 40 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
      Write(Model.Owner.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(912, 27, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Make: ");
            EndContext();
            BeginContext(940, 20, false);
#line 43 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
     Write(Model.Owner.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(960, 39, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Apartment Number: ");
            EndContext();
            BeginContext(1000, 27, false);
#line 46 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
                 Write(Model.Owner.ApartmentNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1048, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea457d10a04d46469c92de4d0241c8c5", async() => {
                BeginContext(1157, 8, true);
                WriteLiteral(" Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-object", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\jia\Desktop\app\DemoCoreApp\DemoCoreApp\Views\Vehicle\VehicleInfo.cshtml"
                                                               WriteLiteral(Model.Owner);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["object"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-object", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["object"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1169, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoCoreApp.ViewModels.OwnerVehicleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
