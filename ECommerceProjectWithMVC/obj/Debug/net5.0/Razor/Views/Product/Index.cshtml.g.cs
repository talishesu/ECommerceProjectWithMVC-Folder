#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb22b5e139d9aa5572a924d46a48f7a3bee6954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb22b5e139d9aa5572a924d46a48f7a3bee6954", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af3000fe509d1bb35d9ab95deb5b2434a77adee", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("review-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <section class=\"pt-5 mt-5\">\r\n      <div class=\"container\">\r\n        <div class=\"heading-section\">\r\n          <h2>");
#nullable restore
#line 10 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
         Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n          \r\n        </div>\r\n        <div class=\"row\">\r\n          <div class=\"col-md-6\">\r\n            <div id=\"slider\" class=\"owl-carousel product-slider\">\r\n");
#nullable restore
#line 16 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                      
                        var MainPhoto = Model.ProductImages.FirstOrDefault(p => p.IsMain == true);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     if(MainPhoto != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdb22b5e139d9aa5572a924d46a48f7a3bee69547697", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 703, "~/uploads/products/images/", 703, 26, true);
#nullable restore
#line 24 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 729, Model.ProductImages.FirstOrDefault(p=>p.IsMain == true).ImagePath, 729, 66, false);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     foreach (var item in Model.ProductImages.Where(p=>p.IsMain == false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdb22b5e139d9aa5572a924d46a48f7a3bee69549987", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1090, "~/uploads/products/images/", 1090, 26, true);
#nullable restore
#line 32 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1116, item.ImagePath, 1116, 15, false);

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
            WriteLiteral("\r\n                          </div>\r\n");
#nullable restore
#line 34 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div id=\"thumb\" class=\"owl-carousel product-thumb\">\r\n");
#nullable restore
#line 37 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     if(MainPhoto != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdb22b5e139d9aa5572a924d46a48f7a3bee695412269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1459, "~/uploads/products/images/", 1459, 26, true);
#nullable restore
#line 41 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1485, Model.ProductImages.FirstOrDefault(p=>p.IsMain == true).ImagePath, 1485, 66, false);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 43 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     foreach (var item in Model.ProductImages.Where(p=>p.IsMain == false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdb22b5e139d9aa5572a924d46a48f7a3bee695414564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1846, "~/uploads/products/images/", 1846, 26, true);
#nullable restore
#line 49 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1872, item.ImagePath, 1872, 15, false);

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
            WriteLiteral("\r\n                          </div>\r\n");
#nullable restore
#line 51 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          </div>\r\n          <div class=\"col-md-6\">\r\n            <div class=\"product-dtl\">\r\n              <div class=\"product-info\">\r\n                <div class=\"product-name\">");
#nullable restore
#line 57 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                     Write(Model.Product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("                <div class=\"product-price-discount\"><span>$");
#nullable restore
#line 73 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                                      Write(Model.ProductPricings.FirstOrDefault().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <div class=\"product-price-discount\"><span>Seller: <p>");
#nullable restore
#line 74 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                                                Write(Model.SellerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span></div>\r\n              </div>\r\n              <p>\r\n                  ");
#nullable restore
#line 77 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
             Write(Model.Product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </p>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb22b5e139d9aa5572a924d46a48f7a3bee695418138", async() => {
                WriteLiteral("\r\n              <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                  <label for=\"color\">Color</label>\r\n                  <select id=\"color\" name=\"colorId\" class=\"form-control\" >\r\n");
#nullable restore
#line 84 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     foreach (var item in Model.ProductPricings)
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb22b5e139d9aa5572a924d46a48f7a3bee695418959", async() => {
#nullable restore
#line 86 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                               Write(item.Color.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                          WriteLiteral(item.ColorId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  </select>
                </div>
              </div>
              <div class=""row"">
                <div class=""col-md-6"">
                  <label for=""size"">Size</label>
                  <select id=""size"" name=""sizeId"" class=""form-control"">
");
#nullable restore
#line 95 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     foreach (var item in Model.ProductPricings)
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb22b5e139d9aa5572a924d46a48f7a3bee695421781", async() => {
#nullable restore
#line 97 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                             Write(item.Size.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                         WriteLiteral(item.SizeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  </select>
                </div>
              </div>
              <div class=""product-count"">
                <label for=""size"">Quantity</label>
                
                  <div class=""qtyminus"">-</div>
                  <input type=""text"" name=""count"" value=""1""  class=""qty"">
                  <div class=""qtyplus"">+</div>
                
                <button type=""submit"" class=""round-black-btn"">Add to Cart</button>
              </div>
              <input");
                BeginWriteAttribute("value", " value=\"", 4859, "\"", 4884, 1);
#nullable restore
#line 111 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
WriteAttributeValue("", 4867, Model.Product.Id, 4867, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"productId\" type=\"hidden\">\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
          </div>
        </div>
        <div class=""product-info-tabs"">
          <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"">
              <a class=""nav-link active"" id=""description-tab"" data-toggle=""tab"" href=""#description"" role=""tab""
                aria-controls=""description"" aria-selected=""true"">Description</a>
            </li>
            <li class=""nav-item"">
              <a class=""nav-link"" id=""review-tab"" data-toggle=""tab"" href=""#review"" role=""tab"" aria-controls=""review""
                aria-selected=""false"">Reviews (");
#nullable restore
#line 124 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                          Write(Model.Product.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n                \r\n            </li>\r\n          </ul>\r\n          <div class=\"tab-content\" id=\"myTabContent\">\r\n            <div class=\"tab-pane fade show active\" id=\"description\" role=\"tabpanel\" aria-labelledby=\"description-tab\">\r\n              ");
#nullable restore
#line 130 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
         Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               <h3 >Specifications:</h3>\r\n");
#nullable restore
#line 132 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
               foreach (var item in Model.Specifications)
                          {
                            var t = Model.SpecificationProductItems.Where(s => s.SpecificationId == item.Id).FirstOrDefault();
                            

                            if(t!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>");
#nullable restore
#line 138 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <h3>");
#nullable restore
#line 139 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                               Write(t.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 140 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                            }
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"review\" role=\"tabpanel\" aria-labelledby=\"review-tab\">\r\n              <div class=\"review-heading\">REVIEWS</div>\r\n");
#nullable restore
#line 146 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                     if(Model.Product.Comments.Count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                         foreach (var item in Model.Product.Comments)
                       {
                           

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"alert alert-light\" role=\"alert\">\r\n                               <p class=\"mb-20\">");
#nullable restore
#line 152 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                           Write(Model.Users.FirstOrDefault(P=>P.Id ==item.CreatedByUserId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 152 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                                                                                            Write(Model.Users.FirstOrDefault(P=>P.Id ==item.CreatedByUserId).Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n                              <p class=\"mb-20\">");
#nullable restore
#line 153 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                          Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 155 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                        
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"mb-20\">There are no reviews yet.</p>\r\n");
#nullable restore
#line 160 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb22b5e139d9aa5572a924d46a48f7a3bee695432367", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                        <div class=""form-group"">
                          <label>Your message</label>
                          <textarea class=""form-control""  name=""comment"" rows=""10""></textarea>
                        </div>
                        <button class=""round-black-btn"">Submit Review</button>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 161 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Views\Product\Index.cshtml"
                                                             WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n          </div>\r\n        </div>\r\n\r\n      </div>\r\n    </section>\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
