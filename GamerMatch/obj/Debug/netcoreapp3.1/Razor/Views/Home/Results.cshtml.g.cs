#pragma checksum "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309bd4e5042f9df24fe7a4555d7a991b4fece895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309bd4e5042f9df24fe7a4555d7a991b4fece895", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f294584dd7adbef1e755691d0f54af5f3089bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetUsers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Results for ");
#nullable restore
#line 11 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table>\r\n");
#nullable restore
#line 13 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
     foreach (AspNetUsers user in Model)
    {
        if (user.UserName != User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4>Username: ");
#nullable restore
#line 19 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
                             Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>Preferred Play Style: ");
#nullable restore
#line 20 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
                                         Write(user.UserPref);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>Match Rating: (To Be Added)</h4>\r\n                    <h4>User Rating: (To Be Added)</h4>\r\n                    <button type=\"button\" value=\"Accept Match\"");
            BeginWriteAttribute("onclick", " onclick=\"", 721, "\"", 816, 3);
            WriteAttributeValue("", 731, "location.href=\'", 731, 15, true);
#nullable restore
#line 23 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
WriteAttributeValue("", 746, Url.Action("MatchUsers", "Match", new { matchUser = user.UserName }), 746, 69, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 815, "\'", 815, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <button>Deny Match</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Results.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591