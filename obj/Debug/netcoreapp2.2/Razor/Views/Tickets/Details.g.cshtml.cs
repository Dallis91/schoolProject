#pragma checksum "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d850231bf5bdb470cb9b5b325d4ed9e4a8bf836a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Details), @"mvc.1.0.view", @"/Views/Tickets/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Details.cshtml", typeof(AspNetCore.Views_Tickets_Details))]
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
#line 1 "D:\Johnathan\Documents\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp;

#line default
#line hidden
#line 2 "D:\Johnathan\Documents\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d850231bf5bdb470cb9b5b325d4ed9e4a8bf836a", @"/Views/Tickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc0e32377224c439721f5a4e91e59e300e681c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ticketApp.Models.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Ticket</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(254, 49, false);
#line 15 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateSubmitted));

#line default
#line hidden
            EndContext();
            BeginContext(303, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(367, 45, false);
#line 18 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateSubmitted));

#line default
#line hidden
            EndContext();
            BeginContext(412, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(475, 44, false);
#line 21 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(519, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(583, 40, false);
#line 24 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(623, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(686, 41, false);
#line 27 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 37, false);
#line 30 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(828, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(891, 41, false);
#line 33 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(932, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(996, 37, false);
#line 36 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1096, 51, false);
#line 39 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationName));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1211, 47, false);
#line 42 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationName));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1321, 47, false);
#line 45 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1432, 43, false);
#line 48 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1538, 40, false);
#line 51 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1642, 36, false);
#line 54 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1741, 46, false);
#line 57 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1851, 42, false);
#line 60 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1956, 50, false);
#line 63 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientPriority));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2070, 46, false);
#line 66 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientPriority));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2179, 47, false);
#line 69 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OurPriority));

#line default
#line hidden
            EndContext();
            BeginContext(2226, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2290, 43, false);
#line 72 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.OurPriority));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2396, 47, false);
#line 75 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointedTo));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2507, 43, false);
#line 78 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointedTo));

#line default
#line hidden
            EndContext();
            BeginContext(2550, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2613, 42, false);
#line 81 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2719, 38, false);
#line 84 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2820, 47, false);
#line 87 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attachments));

#line default
#line hidden
            EndContext();
            BeginContext(2867, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2931, 43, false);
#line 90 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attachments));

#line default
#line hidden
            EndContext();
            BeginContext(2974, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3021, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d850231bf5bdb470cb9b5b325d4ed9e4a8bf836a15105", async() => {
                BeginContext(3067, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "D:\Johnathan\Documents\GitHub\schoolProject\Views\Tickets\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3075, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3083, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d850231bf5bdb470cb9b5b325d4ed9e4a8bf836a17420", async() => {
                BeginContext(3105, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3121, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ticketApp.Models.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
