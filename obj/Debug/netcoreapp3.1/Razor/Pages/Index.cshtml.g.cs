#pragma checksum "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b79a90e14eb4cddc27f66e687dfa8caaed5e64f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(loggingnblog.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace loggingnblog.Pages
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
#line 1 "C:\Users\TOMI\source\repos\loggingnblog\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOMI\source\repos\loggingnblog\Pages\_ViewImports.cshtml"
using loggingnblog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TOMI\source\repos\loggingnblog\Pages\_ViewImports.cshtml"
using loggingnblog.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b79a90e14eb4cddc27f66e687dfa8caaed5e64f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d92eb7a5519bd7d3f699e7abf1095eba1ade41a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n       \r\n");
#nullable restore
#line 9 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
         foreach (var Article in Model.Articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>ID: ");
#nullable restore
#line 11 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
              Write(Article.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Author Name: ");
#nullable restore
#line 12 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
                       Write(Article.ArticleAuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Category: ");
#nullable restore
#line 13 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
                    Write(Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Title: ");
#nullable restore
#line 14 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
                 Write(Article.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Post: ");
#nullable restore
#line 15 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
                Write(Article.ArticlePost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Post: ");
#nullable restore
#line 16 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
                Write(Article.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr />\r\n");
#nullable restore
#line 18 "C:\Users\TOMI\source\repos\loggingnblog\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591