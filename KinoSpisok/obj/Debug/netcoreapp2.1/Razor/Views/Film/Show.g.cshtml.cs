#pragma checksum "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\Film\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2701938d85def2350af627d7e9e66102ab17847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Show), @"mvc.1.0.view", @"/Views/Film/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Film/Show.cshtml", typeof(AspNetCore.Views_Film_Show))]
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
#line 1 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\_ViewImports.cshtml"
using KinoSpisok;

#line default
#line hidden
#line 2 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\_ViewImports.cshtml"
using KinoSpisok.Models;

#line default
#line hidden
#line 3 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\_ViewImports.cshtml"
using KinoSpisok.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2701938d85def2350af627d7e9e66102ab17847", @"/Views/Film/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad18955b672aaa6408cebc04bb668dff57472a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Films>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\Film\Show.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(57, 91, true);
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr><td>Descriptions</td></tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\Film\Show.cshtml"
         foreach(var f in Model)
        {

#line default
#line hidden
            BeginContext(193, 20, true);
            WriteLiteral("            <tr><td>");
            EndContext();
            BeginContext(214, 13, false);
#line 14 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\Film\Show.cshtml"
               Write(f.Description);

#line default
#line hidden
            EndContext();
            BeginContext(227, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 15 "C:\Users\79833\source\repos\KinoSpisok\KinoSpisok\Views\Film\Show.cshtml"
        }

#line default
#line hidden
            BeginContext(250, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Films>> Html { get; private set; }
    }
}
#pragma warning restore 1591