<<<<<<< HEAD
#pragma checksum "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3707f19b66ee630b977bb26a20af7725cdd264b"
=======
#pragma checksum "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5f3572ac3e7a889e065977e51b2d4ce3c17543"
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\_ViewImports.cshtml"
using GamerMatch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3707f19b66ee630b977bb26a20af7725cdd264b", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f294584dd7adbef1e755691d0f54af5f3089bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn text-light btn-hover-text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Preferences", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-light btn-hover-text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
=======
#line 6 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            <button type=\"button\" class=\"nav-link btn text-light badge-info\">");
#nullable restore
<<<<<<< HEAD
#line 9 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                                                        Write(User.Identity.Name);
=======
#line 9 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                                                    Write(User.Identity.Name);
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</button>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3707f19b66ee630b977bb26a20af7725cdd264b7746", async() => {
=======
            WriteLiteral("</button>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5f3572ac3e7a889e065977e51b2d4ce3c175437666", async() => {
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465
                WriteLiteral("Manage Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
<<<<<<< HEAD
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3707f19b66ee630b977bb26a20af7725cdd264b9339", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"nav-link btn text-light btn-hover-text-info\">Logout</button>\r\n            ");
=======
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5f3572ac3e7a889e065977e51b2d4ce3c175439247", async() => {
                WriteLiteral("\r\n            <button  type=\"submit\" class=\"nav-link btn text-light btn-hover-text-info\">Logout</button>\r\n        ");
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                                                                              WriteLiteral(Url.Action("Index", "Home", new { area = "" }));
=======
#line 15 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                                                                           WriteLiteral(Url.Action("Index", "Home", new { area = "" }));
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
    }
    else
    {
=======
#line 19 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
}
else
{
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3707f19b66ee630b977bb26a20af7725cdd264b12608", async() => {
=======
            WriteLiteral("    <li class=\"nav-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5f3572ac3e7a889e065977e51b2d4ce3c1754312466", async() => {
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3707f19b66ee630b977bb26a20af7725cdd264b14111", async() => {
=======
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5f3572ac3e7a889e065977e51b2d4ce3c1754313957", async() => {
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User) && (string)ViewData["Title"] != "Home Page")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"sidenav\">\r\n        <div class=\"col-sm-9\">\r\n            <div>\r\n                <fieldset>\r\n                    <table>\r\n                        <tr><td><h4>Friend List</h4></td></tr>\r\n");
#nullable restore
#line 39 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                         if (ViewData["Friends"] != null)
                        {
                            foreach (var friend in ViewData["Friends"] as List<string>)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                   Write(friend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><button type=\"button\" class=\"rounded badge-info\" value=\"Rate Player\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2072, "\"", 2128, 3);
            WriteAttributeValue("", 2082, "location.href=\'", 2082, 15, true);
#nullable restore
#line 49 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2097, Url.Action("Ratings", "Home"), 2097, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2127, "\'", 2127, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Rate Players</button></td>\r\n                        </tr>\r\n\r\n                    </table>\r\n\r\n                    <table style=\"width: inherit\">\r\n                        <tr><td><h4>Ban List</h4></td></tr>\r\n");
#nullable restore
#line 56 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                         if (ViewData["Bans"] != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                             foreach (var item in ViewData["Bans"] as List<string>)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 61 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                    <button type=\"button\" class=\"rounded badge-info\" value=\"Clear Bans\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2839, "\"", 2894, 3);
            WriteAttributeValue("", 2849, "location.href=\'", 2849, 15, true);
#nullable restore
#line 66 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2864, Url.Action("Clear", "Match"), 2864, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2893, "\'", 2893, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Clear Bans</button>\r\n                </fieldset>\r\n\r\n            </div>\r\n        </div>\r\n    </div>  ");
#nullable restore
#line 71 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
            }
=======
#line 28 "C:\Users\mbate\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Shared\_LoginPartial.cshtml"
}
>>>>>>> c43d603fd98e5ab0d8f4e9e2474e970edb9e2465

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
