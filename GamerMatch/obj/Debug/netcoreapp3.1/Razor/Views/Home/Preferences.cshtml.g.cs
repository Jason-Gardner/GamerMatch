#pragma checksum "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add82a0d02394abcc338c9460f2fa14bbaccbf7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Preferences), @"mvc.1.0.view", @"/Views/Home/Preferences.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add82a0d02394abcc338c9460f2fa14bbaccbf7a", @"/Views/Home/Preferences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f294584dd7adbef1e755691d0f54af5f3089bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Preferences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetUsers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "casual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "competitive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "win", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Preferences"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPerf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ValidationEvent()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
  
    ViewData["Title"] = "Preferences";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Welcome to GroupUp!</h1>\r\n    <p>Please confirm your information:</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add82a0d02394abcc338c9460f2fa14bbaccbf7a6091", async() => {
                WriteLiteral("\r\n        <fieldset>\r\n            <div class=\"form-group\">\r\n                <label for=\"steam\">Steam ID (Optional)</label>\r\n");
#nullable restore
#line 16 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                 if (Model.SteamInfo != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 561, "\"", 591, 1);
#nullable restore
#line 18 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
WriteAttributeValue("", 575, Model.SteamInfo, 575, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                }else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"text\" />\r\n");
#nullable restore
#line 22 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"difficulty\">Select Difficulty</label>\r\n                <select name=\"difficulty\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add82a0d02394abcc338c9460f2fa14bbaccbf7a7978", async() => {
                    WriteLiteral("Current Difficulty is: ");
#nullable restore
#line 28 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                                                                      Write(Model.UserPref);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                       WriteLiteral(Model.UserPref);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add82a0d02394abcc338c9460f2fa14bbaccbf7a9995", async() => {
                    WriteLiteral("Casual");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add82a0d02394abcc338c9460f2fa14bbaccbf7a11238", async() => {
                    WriteLiteral("Competitive");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add82a0d02394abcc338c9460f2fa14bbaccbf7a12487", async() => {
                    WriteLiteral("Play to Win");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"boardgames\">Select Your Favorite Board/Card Games</label>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                 foreach (var item in ViewData["Games"] as List<BoardGames>)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                     if (Model.BoardGamePref != null && Model.BoardGamePref.Contains(@item.Title))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1621, "\"", 1640, 1);
#nullable restore
#line 41 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
WriteAttributeValue("", 1629, item.Title, 1629, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"boardgames\" checked=\"checked\" /><label");
                BeginWriteAttribute("for", " for=\"", 1686, "\"", 1703, 1);
#nullable restore
#line 41 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
WriteAttributeValue("", 1692, item.Title, 1692, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                                                                                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 42 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1844, "\"", 1863, 1);
#nullable restore
#line 45 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
WriteAttributeValue("", 1852, item.Title, 1852, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"boardgames\" /><label");
                BeginWriteAttribute("for", " for=\"", 1891, "\"", 1908, 1);
#nullable restore
#line 45 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
WriteAttributeValue("", 1897, item.Title, 1897, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                                                                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 46 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Jason Gardner\source\repos\GamerMatch\GamerMatch\GamerMatch\Views\Home\Preferences.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <input type=\"submit\" />\r\n        </fieldset>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591