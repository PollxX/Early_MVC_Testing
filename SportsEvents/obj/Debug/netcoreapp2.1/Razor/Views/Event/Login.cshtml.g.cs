#pragma checksum "C:\Users\James\Desktop\SportsEvents\SportsEvents\Views\Event\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00fc72eb22f51a1ee520eadaca324683b87e6130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Login), @"mvc.1.0.view", @"/Views/Event/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Login.cshtml", typeof(AspNetCore.Views_Event_Login))]
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
#line 1 "C:\Users\James\Desktop\SportsEvents\SportsEvents\Views\_ViewImports.cshtml"
using SportsEvents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fc72eb22f51a1ee520eadaca324683b87e6130", @"/Views/Event/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18feed25fd7a1e938b4de16b9c34f07545ff89bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportsEvents.Models.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\James\Desktop\SportsEvents\SportsEvents\Views\Event\Login.cshtml"
 using (Html.BeginForm("EventToPerson", "Person", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(108, 141, true);
            WriteLiteral("    <p>\r\n        <label asp-for=\"Username\">Username</label>\r\n        <br />\r\n        <input name=\"Username\" asp-for=\"Username\" />\r\n    </p>\r\n");
            EndContext();
            BeginContext(251, 157, true);
            WriteLiteral("    <p>\r\n        <label asp-for=\"Password\">Password</label>\r\n        <br />\r\n        <input name=\"Password\" type=\"password\" asp-for=\"Password\" />\r\n    </p>\r\n");
            EndContext();
            BeginContext(410, 43, true);
            WriteLiteral("    <button type=\"submit\">Submit</button>\r\n");
            EndContext();
#line 18 "C:\Users\James\Desktop\SportsEvents\SportsEvents\Views\Event\Login.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportsEvents.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
