#pragma checksum "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c3ae38a3ebbbc57b96fed2ce9be00444d10b670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Verify), @"mvc.1.0.view", @"/Views/Account/Verify.cshtml")]
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
#line 1 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3ae38a3ebbbc57b96fed2ce9be00444d10b670", @"/Views/Account/Verify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Verify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabySit.Database_Access.VerifyCode>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml"
  
    ViewData["Title"] = "Xác minh";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex align-items-center""
     style=""min-height: 100vh"">
    <div class=""col-sm-8 col-md-6 col-lg-4 mx-auto""
         style=""min-width: 300px;"">

        <!--Login Form-->

        <div class=""card navbar-shadow"">
            <div class=""card-body"">
                <!--Form-->
");
#nullable restore
#line 15 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml"
                 using (Html.BeginForm("Verify", "Account", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <h4 class=""card-title text-center"">Xác minh tài khoản</h4>
                    <p class=""Form-subtitle"">
                        Chúng tôi đã gửi một mã xác minh về email của bạn.<br> <br>
                        Vui lòng nhập mã xác minh vào ô dưới đây<br> <br>
                    </p>
                    <!--Code-->
                    <div class=""form-group"">
                        <div class=""form-group"">
                            <div class=""input-group input-group-merge"">
                                ");
#nullable restore
#line 26 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml"
                           Write(Html.TextBoxFor(model => model.CodeInput, new
                                { @id = "codeInput", @class = "form-control form-control-prepended" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                    <br />
                    <!--Submit-->
                    <div class=""form-group "">
                        <button type=""submit""
                                class=""btn btn-success btn-block"">
                            Xác minh
                        </button>
                    </div>
                    <div class=""alert text-danger"">");
#nullable restore
#line 40 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml"
                                              Write(ViewBag.IncorrectCodeMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"card-footer text-center text-black-50\">Đã có tài khoản? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3ae38a3ebbbc57b96fed2ce9be00444d10b6706346", async() => {
                WriteLiteral("Đăng nhập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 42 "C:\Users\bekim\OneDrive\Máy tính\pr2\BabySit\BabySit\Views\Account\Verify.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabySit.Database_Access.VerifyCode> Html { get; private set; }
    }
}
#pragma warning restore 1591
