#pragma checksum "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcdb838b142875597faef1f0549435e3d5be5689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Colors_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Colors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdb838b142875597faef1f0549435e3d5be5689", @"/Areas/Admin/Views/Colors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b340db9081f8f59da501d2ab8c5653283bb4f81f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Colors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Color>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Colors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reverse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n");
#nullable restore
#line 7 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                  <h4 class=\"card-title\">Colors</h4>\r\n                  <p class=\"card-description\">\r\n                      Color List\r\n                  </p>\r\n");
#nullable restore
#line 15 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                   if (User.HasAccess("admin.colors.create"))
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be56899826", async() => {
                WriteLiteral("Create Color");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                           
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  <div class=""table-responsive"">
                    <table class=""table"">
                      <thead>
                        <tr>
                          <th>Id</th>
                          <th>Name</th>
                          <th>Color Hex Code</th>
                          <th>Color</th>
                          <th>Created Time</th>
                          <th>Deleted Time</th>
                          <th>Actions</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 34 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                         foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr>\r\n                              <td>");
#nullable restore
#line 37 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 38 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 39 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                             Write(item.ColorHexCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 40 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                             Write(item.ColorHexCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 41 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                             Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                 if (item.DeletedTime != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><label class=\"badge badge-danger\">Deleted ");
#nullable restore
#line 44 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                                                             Write(item.DeletedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n");
#nullable restore
#line 45 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><label class=\"badge badge-success\">Active</label></td>\r\n");
#nullable restore
#line 47 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <td>\r\n");
#nullable restore
#line 50 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                   if (User.HasAccess("admin.colors.detail"))
                                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be568916290", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n                                  \r\n");
#nullable restore
#line 56 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                     if (item.DeletedTime == null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                         if (User.HasAccess("admin.colors.edit"))
                                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be568920240", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"

                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                       
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  \r\n");
#nullable restore
#line 66 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                     if (item.DeletedTime == null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                         if (User.HasAccess("admin.colors.delete"))
                                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be568924477", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"

                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                       
                                        
                                    }
                                    else{
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                         if (User.HasAccess("admin.colors.reverse"))
                                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be568928375", async() => {
                WriteLiteral("Reverse");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"

                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                                       
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      </tbody>\r\n                    </table>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
#nullable restore
#line 90 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
              }
    else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">Colors</h4>
                  <p class=""card-description"">
                      There Is No Color
                  </p>
                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdb838b142875597faef1f0549435e3d5be568932804", async() => {
                WriteLiteral("Create Color");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 102 "C:\Users\CalenLoki\source\repos\ECommerceProjectWithMVC-Folder\ECommerceProjectWithMVC\Areas\Admin\Views\Colors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Color>> Html { get; private set; }
    }
}
#pragma warning restore 1591
