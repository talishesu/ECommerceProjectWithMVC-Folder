#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c2813b603d0a236929393ec5ad9ddf297c737f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sizes_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Sizes/Detail.cshtml")]
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
using ECommerceProjectWithMVC.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c2813b603d0a236929393ec5ad9ddf297c737f", @"/Areas/Admin/Views/Sizes/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a8e1551ebe3b14564ea86850e39e367fc64ab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sizes_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Size>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin stretch-card\">\r\n              <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                  <h4 class=\"card-title\">Sizes</h4>\r\n                  <p class=\"card-description\">\r\n                      ");
#nullable restore
#line 11 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Size Detail\r\n                  </p>\r\n                    <h1 class=\"display-4\">Name: ");
#nullable restore
#line 13 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Short Name: ");
#nullable restore
#line 14 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                                 Write(Model.ShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Created Time: ");
#nullable restore
#line 15 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                                   Write(Model.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Created By User Id: ");
#nullable restore
#line 16 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                                         Write(Model.CreatedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 17 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                     if(Model.DeletedByUserId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-4\">Deleted By User Id: ");
#nullable restore
#line 18 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                                         Write(Model.DeletedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"display-4\">Deleted Time: ");
#nullable restore
#line 19 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                                                   Write(Model.DeletedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 20 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Sizes\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n              </div>\r\n            </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Size> Html { get; private set; }
    }
}
#pragma warning restore 1591
