#pragma checksum "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3249a286fb6ae9fbf52fcd99f15f7cbba048e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3249a286fb6ae9fbf52fcd99f15f7cbba048e39", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomePage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3249a286fb6ae9fbf52fcd99f15f7cbba048e394068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div>
    <div class=""row"">
        <div class=""card search col-md-9"" style="" padding: 0;"">
            <div class=""box"">
                <div class=""container-1"">
                    <input type=""search"" id=""search"" placeholder=""Tìm kiếm..."" />
                    <a class=""icon"" href=""#""><i class=""fa fa-search""></i></a>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"" style=""margin-left: 0; padding-top:20px;"">
");
#nullable restore
#line 22 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
         foreach (var item in Model.users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card babysitter row col-md-9"" style=""margin-top:20px;"">
                <div class=""no-gutters row"">
                    <div class=""col-lg-3"">
                        <img style=""padding: 20px; height:200px; width:200px;"" data-holder-rendered=""true"" class=""card-img rounded-circle""");
            BeginWriteAttribute("src", " src=\"", 1012, "\"", 1030, 1);
#nullable restore
#line 27 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
WriteAttributeValue("", 1018, item.Avatar, 1018, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-lg-8\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"info-1 row\">\r\n                                <h3 class=\"card-title col-md-12\">");
#nullable restore
#line 32 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"col-md-6\">Nơi làm việc: ");
#nullable restore
#line 33 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                                             Write(item.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                  
                                    var age = DateTime.UtcNow.Year - item.BirthOfDate.Year;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"col-md-6\">Tuổi: ");
#nullable restore
#line 36 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                                         Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tuổi</p>\r\n");
            WriteLiteral("                                <p class=\"col-md-6\">Đánh giá</p>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                 if (item.YearsOfExperience < 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"col-md-6\">Dưới một năm</p>\r\n");
#nullable restore
#line 43 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"col-md-6\">");
#nullable restore
#line 46 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                                   Write(item.YearsOfExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" năm</p>\r\n");
#nullable restore
#line 47 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""info-2 row"">
                                <p class=""col-md-4"">Kỹ năng 1</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 56 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\HomePage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
