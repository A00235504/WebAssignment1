#pragma checksum "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/Intro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bbf603445c36128f9f01793dbf5b0fec8cb3829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAssignment1.Pages.Pages_Intro), @"mvc.1.0.razor-page", @"/Pages/Intro.cshtml")]
namespace WebAssignment1.Pages
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
#line 1 "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/_ViewImports.cshtml"
using WebAssignment1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bbf603445c36128f9f01793dbf5b0fec8cb3829", @"/Pages/Intro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9353e92a9e6b53912204f9a2cd02c229fe3b091", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Intro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/Intro.cshtml"
  
    ViewData["Title"] = "Intro Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Aakash Sadnani</h3>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bbf603445c36128f9f01793dbf5b0fec8cb38293615", async() => {
                WriteLiteral("\n    <div>Enter the Input 1 Number:</div>\n    <div>\n        <input name=\"InputNumber1\" type=\"number\" step=\"1\"");
                BeginWriteAttribute("value", " value=\"", 243, "\"", 270, 1);
#nullable restore
#line 13 "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/Intro.cshtml"
WriteAttributeValue("", 251, Model.InputNumber1, 251, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    </div>\n    <div>Enter the Input 2 Number:</div>\n    <div>\n        <input name=\"InputNumber2\" type=\"number\" step=\"1\"");
                BeginWriteAttribute("value", " value=\"", 394, "\"", 421, 1);
#nullable restore
#line 17 "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/Intro.cshtml"
WriteAttributeValue("", 402, Model.InputNumber2, 402, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    </div>\n    <br />\n    <div>\n        <input name=\"Submit\" type=\"submit\" />\n\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div>Output of Calculator is:</div>\n<output>");
#nullable restore
#line 28 "/Users/aakashsadnani/College docs and projects/Web Course/Assignments/WebAssignment1/WebAssignment1/Pages/Intro.cshtml"
   Write(Model.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</output>\n\n\n");
            DefineSection("NewSection", async() => {
                WriteLiteral("\n    <p>Hi! I am Aakash Sadnani. A cambrian College Student.</p>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAssignment1.Pages.IntroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAssignment1.Pages.IntroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAssignment1.Pages.IntroModel>)PageContext?.ViewData;
        public WebAssignment1.Pages.IntroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591