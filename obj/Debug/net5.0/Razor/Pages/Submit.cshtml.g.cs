#pragma checksum "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56ec979d346ae32ba24244bc51731cfc953911a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adm4379Example.Pages.Pages_Submit), @"mvc.1.0.razor-page", @"/Pages/Submit.cshtml")]
namespace Adm4379Example.Pages
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\_ViewImports.cshtml"
using Adm4379Example;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56ec979d346ae32ba24244bc51731cfc953911a", @"/Pages/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37359e5550fee6f64851791a86985b63d4c00677", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Submit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "button", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateCaseSubmission()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
  
    ViewData["Title"] = "Submit a new business case";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b56ec979d346ae32ba24244bc51731cfc953911a4638", async() => {
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <title>Submit</title>
        <script src=""js/site.js""></script>
        <!-- Global site tag (gtag.js) - Google Analytics -->
        <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-192721075-1""></script>
        <script>
            window.dataLayer = window.dataLayer || [];
            function gtag(){dataLayer.push(arguments);}
            gtag('js', new Date());
            gtag('config', 'UA-192721075-1');
        </script>
        <!-- Google Tag Manager -->
        <script>
            (function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
            new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
            j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
            'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
            })(window,document,'script','dataLayer','GTM-KLDZ6Z2');
        </sc");
                WriteLiteral("ript>\r\n        <!-- End Google Tag Manager -->\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b56ec979d346ae32ba24244bc51731cfc953911a6728", async() => {
                WriteLiteral(@"
        <!-- Google Tag Manager (noscript) -->
        <noscript>
            <iframe src=""https://www.googletagmanager.com/ns.html?id=GTM-KLDZ6Z2"" height=""0"" width=""0"" style=""display:none;visibility:hidden""></iframe>
        </noscript>
        <!-- End Google Tag Manager (noscript) -->
        <div class=""wrapper"">
");
#nullable restore
#line 37 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
             if (TempData.Peek("logged_in") != null) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                 foreach (var user in Model.Users)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                     if (user.email == TempData.Peek("logged_in").ToString()) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h1><span>Submit a Business Case</span></h1>\r\n                        <div class=\"container\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b56ec979d346ae32ba24244bc51731cfc953911a8218", async() => {
                    WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""company"">Company</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <input type=""text"" id=""company"" name=""company"" placeholder=""Company""");
                    BeginWriteAttribute("value", " value=\"", 2386, "\"", 2407, 1);
#nullable restore
#line 49 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
WriteAttributeValue("", 2394, user.company, 2394, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""title"">Business Problem Title</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <input type=""text"" id=""title"" name=""title"" placeholder=""Concise and searchable title"">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""country"">Country</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <select id=""country"" name=""country"">
");
#nullable restore
#line 66 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                                         foreach (var country in Model.Countries)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b56ec979d346ae32ba24244bc51731cfc953911a10675", async() => {
#nullable restore
#line 68 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                                                                             Write(country.name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                                               WriteLiteral(country.country_code);

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
                    WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                        </select>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""bounty"">Bounty</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <input type=""text"" id=""bounty"" name=""bounty"" placeholder=""CAD$"">
                                    </div>
                                </div>
                                    <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""tags"">Tags</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <input type=""text"" id=""tags"" name=""tags"" placeholder=""Relevan");
                    WriteLiteral(@"t tags"">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col25percent"">
                                        <label for=""description"">Business Problem Description</label>
                                    </div>
                                    <div class=""col75percent"">
                                        <textarea id=""description"" name=""description"" placeholder=""Write something..."" style=""height:200px""></textarea>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <input type=""submit"" value=""Submit"" id=""submit_btn"">
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                        break;
                    } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h6 class=\"center\">Error: No User Information Found</h6>\r\n");
#nullable restore
#line 105 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
                 
            } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <a class=\"underline center\" href=\"/Login\"><h6>You must login or create an account to submit a business case</h6></a>\r\n                </div>\r\n");
#nullable restore
#line 111 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Submit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubmitModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SubmitModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SubmitModel>)PageContext?.ViewData;
        public SubmitModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
