#pragma checksum "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8f92b73e2109feade1087378494df573519c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_GetMovieById), @"mvc.1.0.view", @"/Views/Library/GetMovieById.cshtml")]
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
#line 1 "C:\project\03-30\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\project\03-30\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8f92b73e2109feade1087378494df573519c70", @"/Views/Library/GetMovieById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076307135dc47d879fc427f06362ff74e4928b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_GetMovieById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<rolesDemoSSD.ViewModels.MovieVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
  
    ViewData["Title"] = "Movie Library - Rewind";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
Write(Html.DisplayFor(model=> model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>");
#nullable restore
#line 10 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
   Write(Html.DisplayFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.MovieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.PosterSource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.PosterSource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayNameFor(model => model.Distributor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\project\03-30\rolesDemoSSD\Views\Library\GetMovieById.cshtml"
       Write(Html.DisplayFor(model => model.Distributor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<rolesDemoSSD.ViewModels.MovieVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
