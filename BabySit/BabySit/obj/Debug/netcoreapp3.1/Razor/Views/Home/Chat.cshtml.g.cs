#pragma checksum "C:\PRN_9\BabySit\BabySit\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075c1dbf92eefc75869a42bd1001662f7e3a72dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
#line 1 "C:\PRN_9\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PRN_9\BabySit\BabySit\Views\_ViewImports.cshtml"
using BabySit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075c1dbf92eefc75869a42bd1001662f7e3a72dd", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c4939155c2d59677d170f63afeb1878e37e604", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabySit.Database_Access.Babysitter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\" style=\"padding-top:103px;\">\r\n");
#nullable restore
#line 5 "C:\PRN_9\BabySit\BabySit\Views\Home\Chat.cshtml"
     foreach (var item in Model.users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-2\">Gmail</div>\r\n            <div class=\"col-4\"><h3>");
#nullable restore
#line 9 "C:\PRN_9\BabySit\BabySit\Views\Home\Chat.cshtml"
                              Write(Html.DisplayFor(model => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">Phone</div>\r\n            <div class=\"col-4\"><h3>");
#nullable restore
#line 13 "C:\PRN_9\BabySit\BabySit\Views\Home\Chat.cshtml"
                              Write(Html.DisplayFor(model => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\PRN_9\BabySit\BabySit\Views\Home\Chat.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabySit.Database_Access.Babysitter> Html { get; private set; }
    }
}
#pragma warning restore 1591
