#pragma checksum "C:\Users\thiag\Documents\GitHub\TemplateBulma\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bad4d4a5be3052b9250d025e84e36064d3b9d1"
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
#line 1 "C:\Users\thiag\Documents\GitHub\TemplateBulma\Views\_ViewImports.cshtml"
using TemplateBulma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thiag\Documents\GitHub\TemplateBulma\Views\_ViewImports.cshtml"
using TemplateBulma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55bad4d4a5be3052b9250d025e84e36064d3b9d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6263f0e7fa9a47aa293b6e6b7052ef171ae87702", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thiag\Documents\GitHub\TemplateBulma\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section class=""hero is-success is-fullheight"">
        <!-- Hero head: will stick at the top -->
        <div class=""hero-head"">
            <header class=""navbar"">
                <div class=""container"">
                    <div class=""navbar-brand"">
                        <a class=""navbar-item"">
                            <img class=""image is-36x36"" src=""/images/icone2.png"" alt=""Logo"">
                        </a>
                        <span class=""navbar-burger burger"" data-target=""navbarMenuHeroC"">
                            <span></span>
                            <span></span>
                            <span></span>
                        </span>
                    </div>
                    <div id=""navbarMenuHeroC"" class=""navbar-menu"">
                        <div class=""navbar-end"">
                            <a class=""navbar-item is-active"">
                                <span class=""icon"">
                                    <i class=""fas fa-home""></i>
      ");
            WriteLiteral(@"                          </span>

                                Home
                            </a>
                            <a class=""navbar-item"">
                                Como funciona
                                <svg style=""width:24px;height:24px"" viewBox=""0 0 24 24"">
                                    <path fill=""currentColor"" d=""M4,2A2,2 0 0,0 2,4V16A2,2 0 0,0 4,18H8V21A1,1 0 0,0 9,22H9.5V22C9.75,22 10,21.9 10.2,21.71L13.9,18H20A2,2 0 0,0 22,16V4C22,2.89 21.1,2 20,2H4M4,4H20V16H13.08L10,19.08V16H4V4M12.19,5.5C11.3,5.5 10.59,5.68 10.05,6.04C9.5,6.4 9.22,7 9.27,7.69C0.21,7.69 6.57,7.69 11.24,7.69C11.24,7.41 11.34,7.2 11.5,7.06C11.7,6.92 11.92,6.85 12.19,6.85C12.5,6.85 12.77,6.93 12.95,7.11C13.13,7.28 13.22,7.5 13.22,7.8C13.22,8.08 13.14,8.33 13,8.54C12.83,8.76 12.62,8.94 12.36,9.08C11.84,9.4 11.5,9.68 11.29,9.92C11.1,10.16 11,10.5 11,11H13C13,10.72 13.05,10.5 13.14,10.32C13.23,10.15 13.4,10 13.66,9.85C14.12,9.64 14.5,9.36 14.79,9C15.08,8.63 15.23,8.24 15.23,7.8C15.23,7.1 14.96,6");
            WriteLiteral(@".54 14.42,6.12C13.88,5.71 13.13,5.5 12.19,5.5M11,12V14H13V12H11Z"" />
                                </svg>
                            </a>
                            <a class=""navbar-item"">
                                <svg style=""width:24px;height:24px"" viewBox=""0 0 24 24"">
                                    <path fill=""currentColor"" d=""M15.5,12C18,12 20,14 20,16.5C20,17.38 19.75,18.21 19.31,18.9L22.39,22L21,23.39L17.88,20.32C17.19,20.75 16.37,21 15.5,21C13,21 11,19 11,16.5C11,14 13,12 15.5,12M15.5,14A2.5,2.5 0 0,0 13,16.5A2.5,2.5 0 0,0 15.5,19A2.5,2.5 0 0,0 18,16.5A2.5,2.5 0 0,0 15.5,14M13,4V12L10.5,9.75L8,12V4H6V20H10C10.54,20.81 11.23,21.5 12.03,22H6A2,2 0 0,1 4,20V4A2,2 0 0,1 6,2H18A2,2 0 0,1 20,4V11.81C19.42,11.26 18.75,10.81 18,10.5V4H13Z"" />
                                </svg>

                                livros disponíveis
                            </a>
                            <span class=""navbar-item"">
                                <a class=""button is-success is-inve");
            WriteLiteral(@"rted"">
                                    <span>Login</span>
                                    <svg style=""width:24px;height:24px"" viewBox=""0 0 24 24"">
                                        <path fill=""currentColor"" d=""M10,17V14H3V10H10V7L15,12L10,17M10,2H19A2,2 0 0,1 21,4V20A2,2 0 0,1 19,22H10A2,2 0 0,1 8,20V18H10V20H19V4H10V6H8V4A2,2 0 0,1 10,2Z"" />
                                    </svg>
                                </a>
                            </span>
                        </div>
                    </div>
                </div>
            </header>
        </div>



        <!-- Hero content: will be in the middle -->
        <div class=""hero-body"">
            <div class=""container has-text-centered"">
                <h1 class=""title"">
                    LIVRO-A-LIVRO
                </h1>
                <h2 class=""subtitle"">
                    Pegue um, doe outro!
                </h2>
            </div>
        </div>

        <!-- Hero footer: will stic");
            WriteLiteral(@"k at the bottom -->
        <div class=""hero-foot"">
            <nav class=""tabs is-boxed is-fullwidth level is-mobile"">
                <div class=""level-item has-text-centered"">
                    <div>
                        <p class=""heading"">Livros doados</p>
                        <p class=""title"">3,456</p>
                    </div>
                </div>
                <div class=""level-item has-text-centered"">
                    <div>
                        <p class=""heading"">Livros disponíveis</p>
                        <p class=""title"">123</p>
                    </div>
                </div>
                <div class=""level-item has-text-centered"">
                    <div>
                        <p class=""heading"">Total de usuários</p>
                        <p class=""title"">456K</p>
                    </div>
                </div>
                <div class=""level-item has-text-centered"">
                    <div>
                        <p class=""heading"">Total");
            WriteLiteral(" de dinheiro poupado</p>\r\n                        <p class=\"title\">789</p>\r\n                    </div>\r\n                </div>\r\n            </nav>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
