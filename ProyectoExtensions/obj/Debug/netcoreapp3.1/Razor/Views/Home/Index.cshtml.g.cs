#pragma checksum "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a7d88099f285684b0e83ee30f8a15711236cfb"
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
#line 1 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\_ViewImports.cshtml"
using ProyectoExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\_ViewImports.cshtml"
using ProyectoExtensions.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\_ViewImports.cshtml"
using ProyectoExtensions.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a7d88099f285684b0e83ee30f8a15711236cfb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eedea40df59d7f7fe33c665f4495cee0fed271c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoExtensions.Models.Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n");
#nullable restore
#line 12 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
     if (Model != null) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Model.Fecha.GetFechaPersonalizadaString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 39 "C:\Users\carlo\Desktop\FullStack\Net\ProyectoExtensions\ProyectoExtensions\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoExtensions.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
