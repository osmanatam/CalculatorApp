#pragma checksum "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0d037edf19e3fa11956419698a549f5fdce8aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Squareroot_Squareroot), @"mvc.1.0.view", @"/Views/Squareroot/Squareroot.cshtml")]
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
#line 1 "C:\Users\HP\Repos\squarerootWebApp\Views\_ViewImports.cshtml"
using squarerootWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Repos\squarerootWebApp\Views\_ViewImports.cshtml"
using squarerootWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0d037edf19e3fa11956419698a549f5fdce8aa", @"/Views/Squareroot/Squareroot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edabc7782d48ffe2a98afd4f550f05cc17d7b98b", @"/Views/_ViewImports.cshtml")]
    public class Views_Squareroot_Squareroot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("First number"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Second number"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Squareroot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetSqrt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("methods", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
  
    ViewData["Title"] = "Squareroot Page";
    var FirstNumber = ViewBag.FirstNumber;
    var SecondNumber = ViewBag.SecondNumber;
    var SqrtFirstNumber = ViewBag.SqrtFirstNumber;
    var SqrtSecondNumber = ViewBag.SqrtSecondNumber;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">A Square root calculator</h1>\r\n</div>\r\n <div>\r\n    <p> Enter your number </p>\r\n </div>\r\n    <div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0d037edf19e3fa11956419698a549f5fdce8aa5880", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff0d037edf19e3fa11956419698a549f5fdce8aa6142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 17 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff0d037edf19e3fa11956419698a549f5fdce8aa7929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 18 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SecondNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   \r\n\r\n");
#nullable restore
#line 21 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
     if (ViewBag.SqrtFirstNumber > ViewBag.SqrtSecondNumber)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("           <div class = \"text-center\">\r\n                <p>  The number ");
#nullable restore
#line 24 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                           Write(ViewBag.FirstNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root of ");
#nullable restore
#line 24 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                    Write(ViewBag.SqrtFirstNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 24 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                                      Write(ViewBag.SecondNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root ");
#nullable restore
#line 24 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                                                                             Write(ViewBag.SqrtSecondNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
        }
    else if(ViewBag.SqrtSecondNumber > ViewBag.SqrtFirstNumber)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("           <div>\r\n                <p>  The number ");
#nullable restore
#line 30 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                           Write(ViewBag.SecondNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root of ");
#nullable restore
#line 30 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                     Write(ViewBag.SqrtSecondNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 30 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                                        Write(ViewBag.FirstNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root ");
#nullable restore
#line 30 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                                                                              Write(ViewBag.SqrtFirstNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
        }
    else if(ViewBag.SqrtFirstNumber = ViewBag.SqrtSecondNumber)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <p>  Please input different numbers, your numbers have the same square root. </p>\r\n               \r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                 
        }
    else if(ViewBag.FirstNumber < 0 && ViewBag.SecondNumber < 0)
        {
            throw new ArgumentException(
                //InvalidCastException
                "Must provide a duration greater than 0",
                "duration");
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        try
        {

        }
        catch (InvalidOperationException iox)
        {
            throw new Exception(""Some problem with the calculator occured"", iox);
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            Console.WriteLine(""In the finally block"");
        }
            
            

    else if()
        {
            return;
        }
  
  
  
  
  
  <button type=""submit"">Submit</button>  
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
