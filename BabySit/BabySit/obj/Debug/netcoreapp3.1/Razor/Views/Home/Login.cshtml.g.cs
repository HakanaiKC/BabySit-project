#pragma checksum "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f59546377c3c01a1edbd96e40ce99d74e97cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f59546377c3c01a1edbd96e40ce99d74e97cce", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabySit.Database_Acess.RememberMe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgotPass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-black-70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: underline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Đăng nhập";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex align-items-center\" style=\"min-height: 100vh\">\r\n    <div class=\"col-sm-8 col-md-6 col-lg-4 mx-auto\" style=\"min-width: 300px;\">\r\n        <div class=\"card navbar-shadow\">\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 9 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                 using (Html.BeginForm("Login", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <h4 class=\"card-title text-center\">Đăng nhập</h4>\r\n                        ");
#nullable restore
#line 13 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 15 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                       Write(Html.TextBoxFor(model => model.Email, new { @name = "email", @class = "form-control form-control-prepended" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 834, "\"", 856, 1);
#nullable restore
#line 16 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
WriteAttributeValue("", 842, ViewBag.email, 842, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                        </div>\r\n                        ");
#nullable restore
#line 18 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control",@name = "pass" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 25 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.Password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"checkbox\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                       Write(Html.CheckBoxFor(m => m.Remember));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                       Write(Html.LabelFor(model => model.Remember));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 33 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"

                    if (@ViewBag.Message != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"text-danger\">");
#nullable restore
#line 36 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                                              Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 37 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group \">\r\n                        <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Đăng nhập\">\r\n                    </div>\r\n");
#nullable restore
#line 41 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f59546377c3c01a1edbd96e40ce99d74e97cce10323", async() => {
                WriteLiteral("Quên mật khẩu?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer text-center text-black-50\">\r\n                    Chưa có tài khoản? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f59546377c3c01a1edbd96e40ce99d74e97cce11997", async() => {
                WriteLiteral("Đăng ký");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabySit.Database_Acess.RememberMe> Html { get; private set; }
    }
}
#pragma warning restore 1591
