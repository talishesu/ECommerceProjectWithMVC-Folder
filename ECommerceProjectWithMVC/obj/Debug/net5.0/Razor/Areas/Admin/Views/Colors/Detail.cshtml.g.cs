#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd1959a505657cf7e98e7d328e97e7fe60a8e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Colors_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Colors/Detail.cshtml")]
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
#line 1 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1959a505657cf7e98e7d328e97e7fe60a8e86", @"/Areas/Admin/Views/Colors/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a5c04304a50a3841b6efbb9621ea244c18d2d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Colors_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Color>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin stretch-card\">\r\n              <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                  <h4 class=\"card-title\">Colors</h4>\r\n                  <p class=\"card-description\">\r\n                      ");
#nullable restore
#line 11 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Color Detail\r\n                  </p>\r\n                    <h1 class=\"display-4\">Name: ");
#nullable restore
#line 13 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Color: ");
#nullable restore
#line 14 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                            Write(Model.ColorHexCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1");
            BeginWriteAttribute("style", " style=\"", 521, "\"", 565, 2);
            WriteAttributeValue("", 529, "background-color:", 529, 17, true);
#nullable restore
#line 15 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
WriteAttributeValue("", 546, Model.ColorHexCode, 546, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"display-4\">Color</h1>\r\n                    <h1 class=\"display-4\">Created Time: ");
#nullable restore
#line 16 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                                   Write(Model.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Created By User Id: ");
#nullable restore
#line 17 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                                         Write(Model.CreatedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 18 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                     if(Model.DeletedByUserId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-4\">Deleted By User Id: ");
#nullable restore
#line 19 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                                         Write(Model.DeletedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Deleted Time: ");
#nullable restore
#line 20 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                                                   Write(Model.DeletedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 21 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n              </div>\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Color> Html { get; private set; }
    }
}
#pragma warning restore 1591
