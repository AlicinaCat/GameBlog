#pragma checksum "/Users/alicina/Documents/School/ASP.NET/Projects/Project1/GameBlog/GameBlog/Views/Home/PostSubmitted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d2eac6e8788e51fdb4ee9addc48ddefa6eafc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PostSubmitted), @"mvc.1.0.view", @"/Views/Home/PostSubmitted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PostSubmitted.cshtml", typeof(AspNetCore.Views_Home_PostSubmitted))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d2eac6e8788e51fdb4ee9addc48ddefa6eafc2", @"/Views/Home/PostSubmitted.cshtml")]
    public class Views_Home_PostSubmitted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameBlog.ViewModels.PostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 44, true);
            WriteLiteral("\n<h1>Post successfully published!</h1>\n\n<h2>");
            EndContext();
            BeginContext(86, 23, false);
#line 5 "/Users/alicina/Documents/School/ASP.NET/Projects/Project1/GameBlog/GameBlog/Views/Home/PostSubmitted.cshtml"
Write(Model.CurrentPost.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 9, true);
            WriteLiteral("</h2>\n<p>");
            EndContext();
            BeginContext(119, 25, false);
#line 6 "/Users/alicina/Documents/School/ASP.NET/Projects/Project1/GameBlog/GameBlog/Views/Home/PostSubmitted.cshtml"
Write(Model.CurrentPost.Content);

#line default
#line hidden
            EndContext();
            BeginContext(144, 15, true);
            WriteLiteral("</p>\n<p>Posted ");
            EndContext();
            BeginContext(160, 22, false);
#line 7 "/Users/alicina/Documents/School/ASP.NET/Projects/Project1/GameBlog/GameBlog/Views/Home/PostSubmitted.cshtml"
     Write(Model.CurrentPost.Date);

#line default
#line hidden
            EndContext();
            BeginContext(182, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameBlog.ViewModels.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
