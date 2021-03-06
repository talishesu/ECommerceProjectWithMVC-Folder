#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39ee5f0e222072e2babcefe280e3f3d47492b0d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Detail.cshtml")]
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
#nullable restore
#line 5 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.FormModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ee5f0e222072e2babcefe280e3f3d47492b0d0", @"/Areas/Admin/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b340db9081f8f59da501d2ab8c5653283bb4f81f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-sm rounded-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin stretch-card\">\r\n              <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                  <h4 class=\"card-title\">Products</h4>\r\n                  <p class=\"card-description\">\r\n                      ");
#nullable restore
#line 11 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                 Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Product Detail\r\n                  </p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                   foreach (var item in Model.ProductImages.Where(p=>p.IsMain == true))
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <h3 class=\"display-4\">Main Photo</h3>\r\n                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39ee5f0e222072e2babcefe280e3f3d47492b0d06040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 624, "~/uploads/products/images/", 624, 26, true);
#nullable restore
#line 17 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 650, item.ImagePath, 650, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                    if(Model.ProductImages.Where(p=>p.IsMain == false).Any()){

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <h3 class=\"display-4\">Secondary Photo</h3>\r\n");
#nullable restore
#line 21 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                    foreach (var item in Model.ProductImages.Where(p=>p.IsMain == false))
                   {
                           

#line default
#line hidden
#nullable disable
            WriteLiteral("                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39ee5f0e222072e2babcefe280e3f3d47492b0d08695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1041, "~/uploads/products/images/", 1041, 26, true);
#nullable restore
#line 24 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 1067, item.ImagePath, 1067, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                    
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n\r\n\r\n\r\n                    <h3 class=\"display-5\">Name: ");
#nullable restore
#line 31 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Description: ");
#nullable restore
#line 32 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                  Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Short Description: ");
#nullable restore
#line 33 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                        Write(Model.Product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Brand: ");
#nullable restore
#line 34 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                            Write(Model.Product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Category: ");
#nullable restore
#line 35 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                               Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">SKU: ");
#nullable restore
#line 36 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                          Write(Model.Product.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Created Time: ");
#nullable restore
#line 37 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                   Write(Model.Product.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Created By User Id: ");
#nullable restore
#line 38 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                         Write(Model.Product.CreatedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 39 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                     if(Model.Product.DeletedByUserId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"display-5\">Deleted By User Id: ");
#nullable restore
#line 40 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                         Write(Model.Product.DeletedByUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3 class=\"display-5\">Deleted Time: ");
#nullable restore
#line 41 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                   Write(Model.Product.DeletedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 42 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h1 class=\"display-3\">Specifications:</h1>\r\n");
#nullable restore
#line 45 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                           foreach (var item in Model.Specifications)
                          {
                            var t = Model.SpecificationProductItems.Where(s => s.SpecificationId == item.Id).FirstOrDefault();
                            

                            if(t!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>");
#nullable restore
#line 51 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <h3>");
#nullable restore
#line 52 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                               Write(t.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 53 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                            }
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <h1 class=""display-3"">Pricings:</h1>
                    <div class=""table-responsive"">
                    <table class=""table"">
                      <thead>
                        <tr>
                          <th>Color</th>
                          <th>Size</th>
                          <th>Price</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 67 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                           if (Model.ProductPricings.Any())
                            {
                                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                   foreach (var item in Model.ProductPricings)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <tr>\r\n                                      <td>");
#nullable restore
#line 72 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                     Write(Model.AllColors.Where(i=>i.Id == item.ColorId).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 72 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                                                                                            Write(Model.AllColors.Where(i=>i.Id == item.ColorId).FirstOrDefault().ColorHexCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                                      <td>");
#nullable restore
#line 73 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                     Write(Model.AllSizes.Where(i=>i.Id == item.SizeId).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                      <td>");
#nullable restore
#line 74 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 76 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Products\Detail.cshtml"
                                  
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                      </tbody>\r\n                    </table>\r\n                  </div>\r\n\r\n                          \r\n                </div>\r\n                </div>\r\n              </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
