#pragma checksum "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fea9a2fe09856af73cff60e7e08b977004c6a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fea9a2fe09856af73cff60e7e08b977004c6a36", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabySit.Database_Access.UserRegister>
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
#line 1 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Đăng ký";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex align-items-center""
     style=""min-height: 100vh"">
    <div class=""col-sm-8 col-md-6 col-lg-4 mx-auto""
         style=""min-width: 300px; padding-top: 5em;"">

        <div class=""card navbar-shadow"">

            <!--Body-->
            <div class=""card-body"">
");
#nullable restore
#line 15 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                 using (Html.BeginForm("Register", "Account", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"card-title text-center\">Đăng ký</h4>\r\n                    <!--Name-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 20 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.user.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 22 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                       Write(Html.TextBoxFor(model => model.user.Name, new
                            { @id = "name", @class = "form-control form-control-prepended" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 25 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.user.Name, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <!--Email-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 30 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 32 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                       Write(Html.TextBoxFor(model => model.user.Email, new
                            { @id = "email", @class = "form-control form-control-prepended" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 35 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.user.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <!--Password-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 40 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.user.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 42 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                       Write(Html.EditorFor(model => model.user.Password, new
                            { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 45 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.user.Password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <!--Confirm-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 50 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.confirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"input-group input-group-merge\">\r\n                            ");
#nullable restore
#line 52 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                       Write(Html.EditorFor(model => model.confirmPassword, new
                            { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 55 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(mess => mess.confirmPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral(@"                    <!--Checkbox-->
                    <div class=""form-group"">
                        <label class=""form-label""
                               for=""password2"">Bạn là:</label>
                        <div class=""radio-register row"">
                            <div class=""radio-parent col-md-6"">
                                ");
#nullable restore
#line 64 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                           Write(Html.RadioButton("User.Role", "1", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label>Phụ huynh</label>\r\n                            </div>\r\n                            <div class=\"radio-babysitter col-md-6\">\r\n                                ");
#nullable restore
#line 68 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                           Write(Html.RadioButton("User.Role", "2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label>Bảo mẫu</label>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""form-group"">
                        <label class=""form-label""
                               for=""password2"">Bạn là:</label>
                        <div class=""radio-register row"">
                            <div class=""radio-parent col-md-6"">
                                ");
#nullable restore
#line 79 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                           Write(Html.RadioButton("User.Gender", "true", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label>Phụ huynh</label>\r\n                            </div>\r\n                            <div class=\"radio-babysitter col-md-6\">\r\n                                ");
#nullable restore
#line 83 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                           Write(Html.RadioButton("User.Gender", "false"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label>Bảo mẫu</label>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                    <br />
                    <!--Submit-->
                    <div class=""form-group text-center mb-0"">
                        <div class=""custom-control custom-checkbox"">
                            <input id=""terms""
                                   type=""checkbox""
                                   class=""custom-control-input""
                                   checked
                                   required value=""submit"" onclick=""if(!this.form.checkbox.checked){alert('Bạn phải đồng ý với các điều khoản trước.');return false}"">
                            <label for=""terms""
                                   class=""custom-control-label text-black-70"">Bạn cần đồng ý với <a href=""#"">điều khoản về dịch vụ</a> của chúng tôi để tiếp tục</label>
                        </div>
                    </div>
                    <br />
                    <button type=""submit""
                            class=""btn btn-success btn-block mb-3"">
                        Đăng ký
 ");
            WriteLiteral("                   </button>\r\n                    <label style=\"color:red;\" class=\"label-danger\">");
#nullable restore
#line 107 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                                                              Write(ViewBag.DuplicateMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label style=\"color:red;\">");
#nullable restore
#line 108 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                                         Write(ViewBag.EmailExistMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label style=\"color:red;\">");
#nullable restore
#line 109 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                                         Write(ViewBag.PasswordDoNotMatchMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label style=\"color:red;\">");
#nullable restore
#line 110 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                                         Write(ViewBag.InvalidMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label style=\"color:red;\">");
#nullable restore
#line 111 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                                         Write(ViewBag.ErrorSendEmailMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 112 "D:\Software\Fall21\PRN211\Project\Payment\BabySit\BabySit\Views\Account\Register.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-footer text-center text-black-50\">Đã có tài khoản? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fea9a2fe09856af73cff60e7e08b977004c6a3615596", async() => {
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
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabySit.Database_Access.UserRegister> Html { get; private set; }
    }
}
#pragma warning restore 1591
