#pragma checksum "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e9cf6f834659b4ef2cc9dc36401adacd1270d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e9cf6f834659b4ef2cc9dc36401adacd1270d3", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f294584dd7adbef1e755691d0f54af5f3089bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetUsers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\Home\Privacy.cshtml"
 foreach (AspNetUsers user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 16 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\Home\Privacy.cshtml"
   Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 17 "D:\Genie\Documents\GitHub\GamerMatch\GamerMatch\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
