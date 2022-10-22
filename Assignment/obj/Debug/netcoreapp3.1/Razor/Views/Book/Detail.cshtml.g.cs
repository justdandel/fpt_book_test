#pragma checksum "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b359f7142f4b911a7a6bd98f5f16a76159401a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Detail), @"mvc.1.0.view", @"/Views/Book/Detail.cshtml")]
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
#line 1 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\_ViewImports.cshtml"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\_ViewImports.cshtml"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b359f7142f4b911a7a6bd98f5f16a76159401a42", @"/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda4d81eec06e7e0b0808e87a583619ec1ac029e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment.Models.Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
 if(User.IsInRole("StoreOwner")){
    {
        Layout = "StoreOwnerLayout";
    }
}
else {
    Layout = "Layout";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row text-center\">\n    <div class=\"col\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 215, "\"", 231, 1);
#nullable restore
#line 14 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
WriteAttributeValue("", 221, Model.Img, 221, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"auto\" width=\"250\" />\n    </div>\n    <div class=\"col\">\n        <table class=\" table table-bordered\">\n            <tr>\n                <th colspan=\"2\">");
#nullable restore
#line 19 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            </tr>\n            <tr>\n                <th>Price</th>\n                <td>");
#nullable restore
#line 23 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Edition</th>\n                <td>");
#nullable restore
#line 27 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
               Write(Model.Edition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Author</th>\n                <td>");
#nullable restore
#line 31 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
               Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Category</th>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b359f7142f4b911a7a6bd98f5f16a76159401a427123", async() => {
                WriteLiteral("\n                        ");
#nullable restore
#line 38 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
                   Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
                         WriteLiteral(Model.Category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n            <tr>\n                <th>Desciption</th>\n                <td>");
#nullable restore
#line 44 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Quantity</th>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
               Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\n");
#nullable restore
#line 50 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
             if (User.Identity.IsAuthenticated && User.IsInRole("Customer"))
            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th colspan=\"2\" >Add to Cart</th>\r\n                </tr>\n                <tr> \n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b359f7142f4b911a7a6bd98f5f16a76159401a4210891", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"book\"");
                BeginWriteAttribute("value", " value=\"", 1638, "\"", 1655, 1);
#nullable restore
#line 57 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
WriteAttributeValue("", 1646, Model.Id, 1646, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <td style=\"padding-top: 16px;\"><input type=\"number\" name=\"quantity\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 1757, "\"", 1778, 1);
#nullable restore
#line 58 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
WriteAttributeValue("", 1763, Model.Quantity, 1763, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\n                        <td><input type=\"submit\" class=\"btn btn-danger\" value=\"Make Order\" /></td>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </tr>\n");
#nullable restore
#line 62 "C:\Users\Khait\source\repos\ASM_1970-main\Assignment\Views\Book\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n        \n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment.Models.Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
