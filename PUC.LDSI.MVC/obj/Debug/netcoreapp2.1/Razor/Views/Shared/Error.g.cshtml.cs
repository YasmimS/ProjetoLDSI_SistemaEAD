#pragma checksum "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "156e84fa889c44613d5efd50d6cd365552a60abe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\_ViewImports.cshtml"
using PUC.LDSI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\_ViewImports.cshtml"
using PUC.LDSI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156e84fa889c44613d5efd50d6cd365552a60abe", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fbc051568c856e0ae86b15790b1ad608a48f97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 84, true);
            WriteLiteral("<h1 class=\"text-danger\">Ops!</h1>\r\n<h4 style=\"margin-top:30px;\" class=\"text-danger\">");
            EndContext();
            BeginContext(149, 16, false);
#line 6 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
                                            Write(Model.ErrorTitle);

#line default
#line hidden
            EndContext();
            BeginContext(165, 38, true);
            WriteLiteral("</h4>\r\n<h3 style=\"margin-top:30px;\">\r\n");
            EndContext();
#line 8 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
     foreach (var item in Model.Errors)
    {

#line default
#line hidden
            BeginContext(251, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(263, 4, false);
#line 10 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
      Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(267, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
            BeginContext(280, 18, true);
            WriteLiteral("</h3>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(299, 11, false);
#line 14 "C:\Users\Yasmim Sancha\source\repos\1-projeto-base\PUC.LDSI.MVC\Views\Shared\Error.cshtml"
Write(Model.Trace);

#line default
#line hidden
            EndContext();
            BeginContext(310, 124, true);
            WriteLiteral("\r\n</div>\r\n<p style=\"margin-top:30px;\"><a href=\"javascript:window.history.back();\" class=\"btn btn-default\">Voltar</a></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
