#pragma checksum "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "080503f2fb815cd69ba818a365394cb6366a897a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Index.cshtml", typeof(AspNetCore.Views_Tickets_Index))]
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
#line 1 "D:\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp;

#line default
#line hidden
#line 2 "D:\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp.Models;

#line default
#line hidden
#line 3 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
using ticketApp.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080503f2fb815cd69ba818a365394cb6366a897a", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc0e32377224c439721f5a4e91e59e300e681c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ticketApp.Models.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dump", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(223, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Ticket System";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 12 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(362, 24, true);
            WriteLiteral("    <h1>Dashboard</h1>\r\n");
            EndContext();
            BeginContext(388, 16, true);
            WriteLiteral("    <hr />\r\n    ");
            EndContext();
            BeginContext(404, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "080503f2fb815cd69ba818a365394cb6366a897a5388", async() => {
                BeginContext(462, 22, true);
                WriteLiteral("Maak nieuwe ticket aan");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(494, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "080503f2fb815cd69ba818a365394cb6366a897a6861", async() => {
                BeginContext(551, 17, true);
                WriteLiteral("Exporteer Tickets");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(572, 137, true);
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <table class=\"table col-12\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(710, 49, false);
#line 25 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DateSubmitted));

#line default
#line hidden
            EndContext();
            BeginContext(759, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(827, 44, false);
#line 28 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(871, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(939, 41, false);
#line 31 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(980, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1048, 41, false);
#line 34 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1157, 51, false);
#line 37 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicationName));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1276, 47, false);
#line 40 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1391, 40, false);
#line 43 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1499, 46, false);
#line 46 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1613, 49, false);
#line 49 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OurSprintList));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1730, 47, false);
#line 52 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AppointedTo));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1845, 42, false);
#line 55 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 79, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 60 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2023, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2042, "\"", 2123, 5);
            WriteAttributeValue("", 2052, "location.href", 2052, 13, true);
            WriteAttributeValue(" ", 2065, "=", 2066, 2, true);
            WriteAttributeValue(" ", 2067, "\'", 2068, 2, true);
#line 62 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
WriteAttributeValue("", 2069, Url.Action("Details","Tickets", new { @item.ID } ), 2069, 53, false);

#line default
#line hidden
            WriteAttributeValue("", 2122, "\'", 2122, 1, true);
            EndWriteAttribute();
            BeginContext(2124, 53, true);
            WriteLiteral(">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2178, 48, false);
#line 64 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateSubmitted));

#line default
#line hidden
            EndContext();
            BeginContext(2226, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2306, 43, false);
#line 67 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2429, 40, false);
#line 70 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2549, 40, false);
#line 73 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2669, 50, false);
#line 76 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ApplicationName));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2799, 46, false);
#line 79 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2925, 39, false);
#line 82 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2964, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3044, 45, false);
#line 85 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3169, 48, false);
#line 88 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OurSprintList));

#line default
#line hidden
            EndContext();
            BeginContext(3217, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3297, 46, false);
#line 91 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AppointedTo));

#line default
#line hidden
            EndContext();
            BeginContext(3343, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3423, 41, false);
#line 94 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3464, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 97 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3531, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 100 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3575, 66, true);
            WriteLiteral("    <h1>Uw moet ingelogd zijn om deze informatie in te zien</h1>\r\n");
            EndContext();
#line 104 "D:\GitHub\schoolProject\Views\Tickets\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ticketAppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ticketAppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ticketApp.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
