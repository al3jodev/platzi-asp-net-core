#pragma checksum "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31274d62848c479398dda24c2190c6d5cd1476b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#line 2 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31274d62848c479398dda24c2190c6d5cd1476b1", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9c994c8a9f955e5ac98e742f2356b1925f342d", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion Escuela";

#line default
#line hidden
            BeginContext(73, 12, true);
            WriteLiteral("<h1>Escuela ");
            EndContext();
            BeginContext(86, 17, false);
#line 6 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(103, 20, true);
            WriteLiteral("</h1>\r\n<h2>Nombre:  ");
            EndContext();
            BeginContext(124, 12, false);
#line 7 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(136, 28, true);
            WriteLiteral("</h2>\r\n<h3>Tipo de Escuela: ");
            EndContext();
            BeginContext(165, 17, false);
#line 8 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(182, 36, true);
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direccion: ");
            EndContext();
            BeginContext(219, 15, false);
#line 10 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(234, 19, true);
            WriteLiteral("</p>\r\n    <p>Pais: ");
            EndContext();
            BeginContext(254, 10, false);
#line 11 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(264, 21, true);
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
            EndContext();
            BeginContext(286, 12, false);
#line 12 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(298, 45, true);
            WriteLiteral("</p>\r\n</address>\r\n<p><strong>Año fundacion:  ");
            EndContext();
            BeginContext(344, 20, false);
#line 14 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
                      Write(Model.AnioDeCreacion);

#line default
#line hidden
            EndContext();
            BeginContext(364, 23, true);
            WriteLiteral("</strong></p>\r\n\r\n<p><i>");
            EndContext();
            BeginContext(388, 20, false);
#line 16 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(408, 16, true);
            WriteLiteral("</i></p>\r\n<p><i>");
            EndContext();
            BeginContext(425, 24, false);
#line 17 "D:\Fuentes\workspaceNetCore\platzi-asp-net-core\Views\Escuela\Index.cshtml"
 Write(ViewData["CosaDinamica"]);

#line default
#line hidden
            EndContext();
            BeginContext(449, 8, true);
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
