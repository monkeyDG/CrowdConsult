#pragma checksum "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "526d4a54f39f31e40c8f293343c51b2504f0a48d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adm4379Example.Pages.Pages_Case), @"mvc.1.0.razor-page", @"/Pages/Case.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"526d4a54f39f31e40c8f293343c51b2504f0a48d", @"/Pages/Case.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37359e5550fee6f64851791a86985b63d4c00677", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Case : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "button", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateResponseSubmission()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
  
    ViewData["Title"] = "Business case details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "526d4a54f39f31e40c8f293343c51b2504f0a48d4678", async() => {
                WriteLiteral(@"
        <title>Business Case Details</title>
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
        </script>
        <!-- End Google Tag Manager -->
    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "526d4a54f39f31e40c8f293343c51b2504f0a48d6662", async() => {
                WriteLiteral(@"
        <!-- Google Tag Manager (noscript) -->
        <noscript>
            <iframe src=""https://www.googletagmanager.com/ns.html?id=GTM-KLDZ6Z2"" height=""0"" width=""0"" style=""display:none;visibility:hidden""></iframe>
        </noscript>
        <!-- End Google Tag Manager (noscript) -->
        <div class=""wrapper"">
            <!-- HttpContext.Request.Query gets the query string with the key ""id"" (""?id=X"" from the URL), which we need in order to know what case to load -->
            <!-- id is saved as a string in the data model to avoid type conversion here -->
            <!-- we compare the ids for the cases in the database and display it if it's found. IDs must be unique for this to work -->
");
#nullable restore
#line 40 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
             foreach (var bcase in Model.Cases) { 
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                 if (HttpContext.Request.Query["id"] == bcase.id) {
                    Model.caseFound = true;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h1>");
#nullable restore
#line 43 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                   Write(bcase.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <div class=\"case_debrief\">\r\n                        <div>\r\n                            <h7 class=\"h7 center\">");
#nullable restore
#line 46 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                             Write(bcase.company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h7>\r\n");
#nullable restore
#line 47 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                 foreach (var user in Model.Users)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                     if (user.email == bcase.user_email) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p class=\"case_debrief_font\">\r\n                                            <b>Posted by: </b> \r\n                                            <a class=\"underline\"");
                BeginWriteAttribute("href", " href=\"", 2625, "\"", 2650, 2);
                WriteAttributeValue("", 2632, "/Users?id=", 2632, 10, true);
#nullable restore
#line 52 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
WriteAttributeValue("", 2642, user.id, 2642, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                                                      Write(user.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        </p>\r\n");
#nullable restore
#line 54 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                        
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"case_debrief_font\">\r\n                                <b>Keywords: </b> \r\n                                ");
#nullable restore
#line 58 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                           Write(bcase.tags);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <p class=\"case_debrief_font\">\r\n                                <b>Country: </b> \r\n                                ");
#nullable restore
#line 62 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                           Write(bcase.country);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <p class=\"case_debrief_font\">\r\n                                <b>Bounty: </b> \r\n                                CAD$ ");
#nullable restore
#line 66 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                Write(bcase.bounty);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <p class=\"case_debrief_font\" id=\"datetime\"></p>    \r\n                            <script>\r\n                                var datetime = convertEpoch(");
#nullable restore
#line 70 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                       Write(bcase.datetime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
                                document.getElementById(""datetime"").innerHTML = ""<b>Date Posted: </b>"" + datetime;
                            </script>
                        </div>
                    </div>
                    <div>
                        <h2>Full Case</h2>
                        <div class=""flex-wrapper"">
                            <div class=""box2"">
                                <p class =""case_full_font"">");
#nullable restore
#line 79 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                      Write(bcase.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 83 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"

                    //@if (string.IsNullOrEmpty(HttpContext.Session.GetString(CaseModel.SessionKeyEmail))) { <----- DEPRECATED IN FAVOR OF TempData BELOW FOR LOGIN CHECK:
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                     if (TempData.Peek("logged_in") != null) {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                         if (1==1) {}

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <h2>Respond to this business case</h2>\r\n                            <div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "526d4a54f39f31e40c8f293343c51b2504f0a48d14401", async() => {
                    WriteLiteral("\r\n                                    <textarea id=\"response_content\" name=\"response_content\" placeholder=\"Write your response...\" style=\"height:300px\"></textarea>\r\n                                    <input type=\"hidden\" id=\"case_id\" name=\"case_id\"");
                    BeginWriteAttribute("value", " value=\"", 4916, "\"", 4933, 1);
#nullable restore
#line 92 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
WriteAttributeValue("", 4924, bcase.id, 4924, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <input type=\"submit\" value=\"Submit\" id=\"submit_response_btn\">\r\n                                ");
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
                WriteLiteral("\r\n                                <br>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 98 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <a class=\"underline center\" href=\"/Login\"><h6>You must login to post a reponse to this case</h6></a>\r\n                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <h2>Responses</h2>\r\n");
#nullable restore
#line 105 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                         foreach (var response in bcase.Responses) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div style=\"text-align: left;\">\r\n                                <div class=\"flex-wrapper\">\r\n                                    <div class=\"box2\">\r\n");
#nullable restore
#line 109 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                         foreach (var user in Model.Users) { 
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                             if (response.response_user == user.email) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <a class=\"underline\"");
                BeginWriteAttribute("href", " href=\"", 5985, "\"", 6009, 2);
                WriteAttributeValue("", 5992, "/User?id=", 5992, 9, true);
#nullable restore
#line 111 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
WriteAttributeValue("", 6001, user.id, 6001, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h2 class=\"responder_name nopad\">");
#nullable restore
#line 111 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                                                                                          Write(user.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2></a>\r\n");
#nullable restore
#line 112 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p class=\"responder_date\"");
                BeginWriteAttribute("id", " id=\"", 6220, "\"", 6266, 2);
                WriteAttributeValue("", 6225, "response_datetime_", 6225, 18, true);
#nullable restore
#line 114 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
WriteAttributeValue("", 6243, response.response_user, 6243, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></p>    \r\n                                        <script>\r\n                                            var legibleDate = convertEpoch(");
#nullable restore
#line 116 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                                      Write(response.response_datetime);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n                                            document.getElementById(\"response_datetime_");
#nullable restore
#line 117 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                                                  Write(response.response_user);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").innerHTML = \"<b>Date Posted: </b>\" + legibleDate;\r\n                                        </script>\r\n                                        <p class =\"case_full_font\">");
#nullable restore
#line 119 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                              Write(response.response_description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n                                    </div> \r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 123 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 125 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                    break;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
             if (Model.caseFound == false) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1>Sorry, we can\'t find that business case.</h1>\r\n                <div class=\"center\"><button class=\"btn2\" onclick=\"location.href=\'/Active\';\">Go back to active business cases</button></div>\r\n");
#nullable restore
#line 131 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CaseModel>)PageContext?.ViewData;
        public CaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
