#pragma checksum "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb03b88c6af2a231c6e2e0eed8904559fe104493"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
using AriBilgi.ArticleApp.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb03b88c6af2a231c6e2e0eed8904559fe104493", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17c556495ddc89760b9216148b0f29d125127a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    #nullable disable
    {
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
        private global::AriBilgi.ArticleApp.TagHelpers.ShortText __AriBilgi_ArticleApp_TagHelpers_ShortText;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
  
    foreach (Article item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mt-3\">\n          <div class=\"card-header\">\n            ");
#nullable restore
#line 13 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          </div>\n          <div class=\"card-body\">\n            <blockquote class=\"blockquote mb-0\">\n            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getShortText", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb03b88c6af2a231c6e2e0eed8904559fe1044933928", async() => {
                WriteLiteral(" ");
            }
            );
            __AriBilgi_ArticleApp_TagHelpers_ShortText = CreateTagHelper<global::AriBilgi.ArticleApp.TagHelpers.ShortText>();
            __tagHelperExecutionContext.Add(__AriBilgi_ArticleApp_TagHelpers_ShortText);
#nullable restore
#line 17 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
__AriBilgi_ArticleApp_TagHelpers_ShortText.ApplicationUserIdHtml = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("application-user-id-html", __AriBilgi_ArticleApp_TagHelpers_ShortText.ApplicationUserIdHtml, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("...</p>\n            <P><a");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 501, 2);
            WriteAttributeValue("", 466, "/Home/TextDetail?ArticleId=", 466, 27, true);
#nullable restore
#line 18 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 493, item.Id, 493, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary btn-sm\">Devamını oku</a></P>\n              <footer class=\"blockquote-footer\">");
#nullable restore
#line 19 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
                                           Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <cite title=\"Source Title\">");
#nullable restore
#line 19 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"
                                                                                   Write(item.dateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</cite></footer>\n            </blockquote>\n          </div>\n        </div>\n");
#nullable restore
#line 23 "C:\Users\Ali Toraman\Desktop\C# Çalışmalarım\Core\16.09.2022\AriBilgi.ArticleApp\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
