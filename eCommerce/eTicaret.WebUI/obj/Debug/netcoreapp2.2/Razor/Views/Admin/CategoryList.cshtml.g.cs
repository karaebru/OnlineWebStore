#pragma checksum "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c40adf38cfd8e7d00a9f92d32156a5b80c3df2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CategoryList.cshtml", typeof(AspNetCore.Views_Admin_CategoryList))]
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
#line 1 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\_ViewImports.cshtml"
using eTicaret.Entities;

#line default
#line hidden
#line 2 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\_ViewImports.cshtml"
using eTicaret.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\_ViewImports.cshtml"
using eTicaret.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c40adf38cfd8e7d00a9f92d32156a5b80c3df2b", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0710493396d54c67ab1afcaffb33e4caa1576856", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletecategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";

#line default
#line hidden
            BeginContext(70, 35, true);
            WriteLiteral("\n<h1>Admin Categories</h1>\n<hr />\n\n");
            EndContext();
#line 9 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
 if (Model.Categories.Count() > 0)
{


#line default
#line hidden
            BeginContext(143, 271, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">Name</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
            BeginContext(480, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(526, 7, false);
#line 24 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(533, 48, true);
            WriteLiteral("</td>                  \n                    <td>");
            EndContext();
            BeginContext(582, 9, false);
#line 25 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(591, 93, true);
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 684, "\"", 719, 2);
            WriteAttributeValue("", 691, "/admin/editcategory/", 691, 20, true);
#line 27 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 711, item.Id, 711, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(720, 34, true);
            WriteLiteral(">Edit</a>\n                        ");
            EndContext();
            BeginContext(754, 290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c40adf38cfd8e7d00a9f92d32156a5b80c3df2b7122", async() => {
                BeginContext(829, 67, true);
                WriteLiteral("\n                            <input type=\"hidden\" name=\"categoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 896, "\"", 912, 1);
#line 29 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 904, item.Id, 904, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(913, 124, true);
                WriteLiteral(" />\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 34 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
            }

#line default
#line hidden
            BeginContext(1107, 32, true);
            WriteLiteral("\n        </tbody>\n\n    </table>\n");
            EndContext();
#line 39 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1148, 78, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\n        <h4>No Products</h4>\n    </div>\n");
            EndContext();
#line 45 "C:\Users\Gano\Desktop\g131210085_g151210086\eTicaret\eTicaret.WebUI\Views\Admin\CategoryList.cshtml"
}

#line default
#line hidden
            BeginContext(1228, 4, true);
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
