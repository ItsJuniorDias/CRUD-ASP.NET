#pragma checksum "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bc8bc83bd0dc12cfa68f14f8d0f075c9a9c781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bc8bc83bd0dc12cfa68f14f8d0f075c9a9c781", @"/Views/Produto/Index.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
  
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 41, true);
            WriteLiteral("\r\n    <table class=\"table table-hover\">\r\n");
            EndContext();
#line 10 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
         foreach(var produto in Model)
        {

#line default
#line hidden
            BeginContext(196, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(227, 17, false);
#line 13 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
           Write(produto.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(244, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(268, 12, false);
#line 14 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
           Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(280, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(304, 17, false);
#line 15 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
           Write(produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(321, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(345, 13, false);
#line 16 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
           Write(produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(358, 62, true);
            WriteLiteral("</td>\r\n        <td>\r\n             <a class=\"btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 420, "\"", 461, 2);
            WriteAttributeValue("", 427, "/produto/delete/", 427, 16, true);
#line 18 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
WriteAttributeValue("", 443, produto.IdProduto, 443, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(462, 57, true);
            WriteLiteral("> Apagar </a>\r\n             <a class=\"btn-sm btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 519, "\"", 560, 2);
            WriteAttributeValue("", 526, "/produto/Update/", 526, 16, true);
#line 19 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
WriteAttributeValue("", 542, produto.IdProduto, 542, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 45, true);
            WriteLiteral("> Editar </a>\r\n        </td>\r\n        </tr>\r\n");
            EndContext();
#line 22 "C:\Users\MAQ01LAB05\ecommerce\Views\Produto\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(617, 91, true);
            WriteLiteral("    </table>\r\n    \r\n    <a class=\"btn btn-primary\" href=\"/produto/create\"> Adicionar </a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
