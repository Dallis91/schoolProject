#pragma checksum "C:\Users\Stefan\Documents\GitHub\schoolProject\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f0ad571e517777751addfb49bb7a088cc4d6c09"
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
#line 1 "C:\Users\Stefan\Documents\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp;

#line default
#line hidden
#line 2 "C:\Users\Stefan\Documents\GitHub\schoolProject\Views\_ViewImports.cshtml"
using ticketApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f0ad571e517777751addfb49bb7a088cc4d6c09", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc0e32377224c439721f5a4e91e59e300e681c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stefan\Documents\GitHub\schoolProject\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Over ons";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\Stefan\Documents\GitHub\schoolProject\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 1680, true);
            WriteLiteral(@"</h1>
<p>
    Ons team bestaat uit de volgende personen;
    <ul>
        <li>Johnathan Dall - Full-stack developer/C# developer</li>
        <li>Nick van de Pepel - Teamleider/Scrum master</li>
        <li>Stevan van de Kamp - Front-end developer</li>
        <li>Stevan van Waveren - Front-end developer</li>
    </ul>
</p>

<h2>De App</h2>
<p>
    Deze app is schreven voor Trenton bv.
    De opdracht die aan ons is gegeven is het moderniseren hun interne ticketing system. Deze was geschreven in de tijd dat ASP.NET Webforms modern was.
</p>

<h2>Achterliggend Techniek</h2>
<p>
    <ul>
        <li>
            <h3>ASP.NET Core</h3>
        </li>
        ASP.NET Core is de nieuwste iteratie van de webframework gecreerd door Microsoft. Deze framework is geinspirereert door de oude ASP.NET framework. In tegenstelling tot de oude framework word ASP.NET Core ontwikkeld als een modulair open-source framework die, in de toekomst, zowel voor websites als cross-platform .NET framework applicatie");
            WriteLiteral(@" geschreven word.
        <li>
            <h4>MVC</h4>
        </li>
        Model View Controller (MVC) MVC is een ontwerppatroon dat wordt gebruikt om gebruikersinterface (weergave), gegevens (model) en toepassingslogica (controller) te ontkoppelen. Dit patroon helpt om zorgen te scheiden.
        <li>
            <h3>Entity Framework Core</h3>
        </li>
        Entity Framework (EF) Core is een lichtgewicht en uitbreidbare versie van de populaire Entity Framework-gegevenstoegangstechnologie. EF Core is een object-relationele mapper (O / RM) waarmee .NET-ontwikkelaars met .NET-objecten kunnen werken met een database.
    </ul>
</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
