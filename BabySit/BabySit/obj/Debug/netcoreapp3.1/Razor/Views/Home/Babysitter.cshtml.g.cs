#pragma checksum "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a718827a17d6ed9142761ef2e94752596351dd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Babysitter), @"mvc.1.0.view", @"/Views/Home/Babysitter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718827a17d6ed9142761ef2e94752596351dd9a", @"/Views/Home/Babysitter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Babysitter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabySit.Database_Acess.Babysitter>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/star-rating-svg.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.star-rating-svg.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateContract", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
  
    ViewData["Title"] = "Bảo mẫu";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a718827a17d6ed9142761ef2e94752596351dd9a5499", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a718827a17d6ed9142761ef2e94752596351dd9a6613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"page-content\" style=\"padding-top: 6em;\">\r\n\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 11 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
         foreach (var item in Model.users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card babysitter row col-md-12\">\r\n");
            WriteLiteral("                <div class=\"no-gutters row\">\r\n                    <div class=\"col-lg-3\">\r\n                        <img style=\"padding: 20px; height:200px; width:200px;\" data-holder-rendered=\"true\" class=\"card-img rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 669, "\"", 687, 1);
#nullable restore
#line 17 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
WriteAttributeValue("", 675, item.Avatar, 675, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-lg-8\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"info-1 row\">\r\n                                <h3 class=\"card-title col-md-12\">");
#nullable restore
#line 22 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                                                            Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"col-md-6\">");
#nullable restore
#line 23 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                                               Write(Html.DisplayFor(model => item.Province.ProvinceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"col-md-6\">");
#nullable restore
#line 24 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                                               Write(Html.DisplayFor(model => item.BirthOfDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <br />\r\n");
            WriteLiteral("            <div class=\"introAndContact row\">\r\n");
            WriteLiteral("                <div class=\"intro col-md-8\">\r\n                    <h3>Giới thiệu</h3>\r\n                    <p>");
#nullable restore
#line 37 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                  Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n");
            WriteLiteral("                <div class=\"contract col-md-4 card\" style=\"margin:auto;\">\r\n                    <h3>Mức lương yêu cầu</h3>\r\n                    <strong>");
#nullable restore
#line 43 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                       Write(Html.DisplayFor(model => item.SalaryPerHour));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND/ giờ</strong>\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a718827a17d6ed9142761ef2e94752596351dd9a11306", async() => {
                WriteLiteral("Tạo hợp đồng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"kinhnghiem\">\r\n                <h3>Kinh nghiệm</h3>\r\n");
#nullable restore
#line 53 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                 if (item.YearsOfExperience < 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Dưới một năm</p>\r\n");
#nullable restore
#line 56 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 59 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                  Write(Html.DisplayFor(model => item.YearsOfExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral(" năm</p>\r\n");
#nullable restore
#line 60 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n\r\n");
            WriteLiteral("        <div class=\"skill\">\r\n            <h3>Kỹ năng</h3>\r\n            <div class=\"skills row col-md-5\">\r\n");
#nullable restore
#line 70 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                 foreach (var skill in Model.skills.Where(x => x.SkillId >= 6 && x.SkillId <= 12))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"col-md-4\">");
#nullable restore
#line 72 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                                   Write(skill.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 73 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("        <h3>Có kinh nghiệm với</h3>\r\n        <div class=\"experience-with row\">\r\n");
#nullable restore
#line 81 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
             foreach (var skill in Model.skills.Where(x => x.SkillId >= 1 && x.SkillId <= 5))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-2 py-2 text-center\">\r\n                    <div class=\"card card-body h-100\">\r\n                        ");
#nullable restore
#line 85 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
                   Write(skill.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Users\bekim\OneDrive\Máy tính\Babysit\BabySit\BabySit\Views\Home\Babysitter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <br />\r\n");
            WriteLiteral(@"        <div class=""time-shift"">
            <h3>Thời gian làm việc</h3>
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered table-schedule"">
                    <thead>
                    <th class=""empty""></th>
                    <th>Thứ Hai</th>
                    <th>Thứ Ba</th>
                    <th>Thứ Tư</th>
                    <th>Thứ Năm</th>
                    <th>Thứ Sáu</th>
                    <th>Thứ Bảy</th>
                    <th>Chủ Nhật</th>
                    </thead>
                    <tbody>
                        <tr>
                            <td class=""time"">Sáng</td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-times""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-times""></i></td>
   ");
            WriteLiteral(@"                         <td><i class=""fas fa-times""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                        </tr>

                        <tr>
                            <td class=""time"">Chiều</td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-times""></i></td>
                            <td><i class=""fas fa-times""></i></td>
                            <td><i class=""fas fa-times""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                        </tr>

                        <tr>
                            <td class=""time"">Tối</td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td><i class=""fas fa-tim");
            WriteLiteral(@"es""></i></td>
                            <td><i class=""fas fa-check""></i></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <br />
");
            WriteLiteral(@"        <div class=""rate"">
            <h3>Đánh giá</h3>
            <div class=""no-gutters row"">
                <div class=""col-md-3"">
                    <img style=""padding: 20px; height:100px; width:100px;"" data-holder-rendered=""true"" class=""card-img rounded-circle"" src=""https://mdbootstrap.com/img/Photos/Avatars/img%20(31).jpg"">
                </div>
                <div class=""star col-md-6"">
                    <label class=""col-md-3"">Tên</label>
                    <label class=""col-md-3""><span class=""rate-total"" data-rating=""4.8"" id=""starrate""></span></label>
                </div>
                <div class=""col-md-3"">
                    <div class=""date-time"">Ngày</div>
                </div>
                <div class=""col-md-12"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            WriteLiteral(@" Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
                </div>
            </div>
        </div>
    </div>
    }
</section>

<script>
    $(function () {
        $("".rate-total"").starRating({
            totalStars: 5,
            starSize: 20,
            activeColor: 'rgb(242, 208, 73)',
            useGradient: false,
            readOnly: true
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabySit.Database_Acess.Babysitter> Html { get; private set; }
    }
}
#pragma warning restore 1591
