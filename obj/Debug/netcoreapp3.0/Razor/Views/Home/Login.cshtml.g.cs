#pragma checksum "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32909479448d84794bd44cc197429a776904bf7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\_ViewImports.cshtml"
using ControlTesisCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\_ViewImports.cshtml"
using ControlTesisCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32909479448d84794bd44cc197429a776904bf7d", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274b9a5ea24d3f346d71b85b772bb71996b81b90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControlTesisCore.Models.BD.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
  
    ViewData["Title"]= "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            \r\n            ");
#nullable restore
#line 11 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 13 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
           Write(Html.LabelFor(model => model.Carnet, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 15 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
               Write(Html.EditorFor(model => model.Carnet, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
               Write(Html.ValidationMessageFor(model => model.Carnet, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <p></p>\r\n                ");
#nullable restore
#line 19 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
           Write(Html.LabelFor(model => model.Contraseña, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 21 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
               Write(Html.PasswordFor(model => model.Contraseña, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
               Write(Html.ValidationMessageFor(model => model.Contraseña, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div>\r\n                    <input type=\"submit\" value=\"Ingresar\" class=\"btn btn-primary\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "c:\Users\sergi\Desktop\core\ControlTesisCore\Views\Home\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControlTesisCore.Models.BD.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591