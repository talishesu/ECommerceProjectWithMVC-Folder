#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95fbae7607d3d4471a2b2637c6b2fefe1249b07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
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
#line 1 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\_ViewImports.cshtml"
using ECommerceProjectWithMVC.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95fbae7607d3d4471a2b2637c6b2fefe1249b07", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af3000fe509d1bb35d9ab95deb5b2434a77adee", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserCardItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n      <section\r\n        class=\"card-body d-flex flex-column justify-content-center align-items-center\"\r\n      >\r\n        <div class=\"shopping-cart\">\r\n          <!-- Title -->\r\n");
#nullable restore
#line 12 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
           if(Model.Count !=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div>\r\n            <div class=\"title d-flex justify-content-between\">\r\n              <h4>Shopping Bag</h4>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95fbae7607d3d4471a2b2637c6b2fefe1249b078897", async() => {
                WriteLiteral("Remove All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n          </div>\r\n          <!-- Products -->\r\n");
#nullable restore
#line 20 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
           foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95fbae7607d3d4471a2b2637c6b2fefe1249b0710499", async() => {
                WriteLiteral(@"
             <div class=""item align-items-center"">
                <div class=""buttons"">
                  <span class=""delete-btn-card""></span>
                  <span class=""like-btn-card""></span>
                </div>

                <div class=""image"">
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d95fbae7607d3d4471a2b2637c6b2fefe1249b0711051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1141, "~/uploads/products/images/", 1141, 26, true);
#nullable restore
#line 32 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
AddHtmlAttributeValue("", 1167, item.ProductPricing.Product.Images.FirstOrDefault(pp=>pp.IsMain == true).ImagePath, 1167, 83, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"description\">\r\n                  <span>");
#nullable restore
#line 38 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
                WriteLiteral("                  <span>");
#nullable restore
#line 40 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Size.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
                WriteLiteral("                  <span>");
#nullable restore
#line 42 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                   Write(item.ProductPricing.Color.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
                WriteLiteral("                </div>\r\n\r\n                <div class=\"quantity\">\r\n");
                WriteLiteral("                  <p id=\"product-count\" data-product-count=\"");
#nullable restore
#line 50 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                       Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Count:");
#nullable restore
#line 50 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                          Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n              \r\n              \r\n                </div>\r\n\r\n                \r\n\r\n                <div class=\"total-price\">Product price: $");
#nullable restore
#line 57 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                    Write(item.ProductPricing.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n                </div>\r\n                <div class=\"total-price\" id=\"total-price\" data-product-price=\"");
#nullable restore
#line 60 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                         Write(item.ProductPricing.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"> Total Price Product: $<span class=\"total-amount  badge-primary dark\">");
#nullable restore
#line 60 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                                                                                                            Write(item.ProductPricing.Price*item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 2673, "\"", 2681, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button class=\"minus-btn-card\" type=\"submit\">\r\n                        <img src=\"./assets/svg/minus.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2809, "\"", 2815, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                  </button>\r\n                </div>\r\n              </div>\r\n             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-colorId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                             WriteLiteral(item.ProductPricing.Color.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["colorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-colorId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["colorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                              WriteLiteral(item.ProductPricing.Size.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["sizeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sizeId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["sizeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
                                                                                                                                                 WriteLiteral(item.ProductPricing.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
              

          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"title d-flex justify-content-between\">\r\n              <h4>Not Have Product</h4>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95fbae7607d3d4471a2b2637c6b2fefe1249b0721418", async() => {
                WriteLiteral("Go To Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Card\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95fbae7607d3d4471a2b2637c6b2fefe1249b0723151", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </section>\r\n    \r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("      ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserCardItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
