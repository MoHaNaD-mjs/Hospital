#pragma checksum "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4736c653fed38f084ea002c19921d0788743c7bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_CommonQuestions_Index), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/CommonQuestions/Index.cshtml")]
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
#line 1 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web.helpers.tageHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Core.Dtos_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web.Areas.Admin.Pages.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Web.helpers.pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\projects\Hospital\Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Infrastructure.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4736c653fed38f084ea002c19921d0788743c7bf", @"/Areas/Admin/Pages/CommonQuestions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d36aba581800d3cff6e88792531e0019f05f5a0", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_CommonQuestions_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ContentHeaderMain", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_lengthMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteAllModel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
  
    string headerName = "CommonQuestions";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
Write(await Html.PartialAsync("_DataTableStylesPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4736c653fed38f084ea002c19921d0788743c7bf8187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4736c653fed38f084ea002c19921d0788743c7bf9389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 10 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = headerName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header border-0 m-0  "">
                        <div class=""d-flex flex-md-row flex-column flex-sm-column justify-content-between"">
                            <div id=""search "" class=""   mb-1"">
                                <div style=""direction:ltr"" class=""input-group input-group-sm   "">
                                    <input id=""text-search"" type=""search"" class=""form-control"">
                                    <select id=""select-search"" class=""custom-select custom-select-sm"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4736c653fed38f084ea002c19921d0788743c7bf11941", async() => {
#nullable restore
#line 24 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                                         Write(Localizer["title"].Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                    </select>
                                    <span class=""input-group-append"">
                                        <button id=""btn-search"" type=""button"" class=""btn btn-info btn-flat""> <i class=""fa fa-search""></i></button>
                                    </span>
                                </div>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4736c653fed38f084ea002c19921d0788743c7bf13730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                    <!-- /.card-header -->
                    <div class=""card-body"">
 

                        <table id=""mainTable"" class=""text-capitalize table text-center table-bordered table-striped dataTable dtr-inline"" role=""grid"" aria-describedby=""example1_info"">
                            <thead>
                                <tr>

                                    <th>
                                        <div class=""icheck-primary d-inline"">
                                            <input type=""checkbox"" id=""checkboxmain"">
                                            <label for=""checkboxmain"">
                                            </label>
                                        </div>
                                    </th>
                                    <th>");
#nullable restore
#line 50 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                   Write(Localizer["title"].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 51 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                   Write(Localizer["description"].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 56 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                 foreach (var question in Model.commonQuestions)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td>
                                            <div class=""icheck-primary d-inline"">
                                                <input onchange=""subCheck(this)"" class=""check-sub"" type=""checkbox""");
            BeginWriteAttribute("id", " id=\"", 3132, "\"", 3149, 1);
#nullable restore
#line 61 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
WriteAttributeValue("", 3137, question.Id, 3137, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 3207, "\"", 3225, 1);
#nullable restore
#line 62 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
WriteAttributeValue("", 3213, question.Id, 3213, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </label>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 65 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                        Write(Model.lang=="en" ? question.Title: question.TitleAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 66 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                        Write(Model.lang=="en" ? question.description: question.descriptionAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"d-none hidden\">");
#nullable restore
#line 67 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                                             Write(question.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 70 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>


                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4736c653fed38f084ea002c19921d0788743c7bf19561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 89 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 90 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
Write(await Html.PartialAsync("_DataTableScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
             var url = ""/Admin/CommonQuestions/Index?handler=NewsList"";
            var urlAction = ""/Admin/CommonQuestions/"";
            var colums = [

                {
                    data: null,
                    render: function (data, type, row) {

                         return `<div      class='icheck-primary d-inline  '>
                                    <input  onchange='subCheck(this)'  class=""check-sub""   type = 'checkbox' id = '${data.id}'   >
                                        <label for='${data.id}'>
                                        </label>
                                        </div>`

                    }

                },

                // For Student.Firstname
                { data: """);
#nullable restore
#line 111 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                    Write(Model.lang);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" === \"en\" ? \"title\" : \"titleAr\"  },\r\n                { data: \"");
#nullable restore
#line 112 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                    Write(Model.lang);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" === \"en\" ? \"description\" : \"descriptionAr\"  },\r\n                { data: \"id\" }\r\n            ];\r\n            var lang = \"");
#nullable restore
#line 115 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                   Write(Model.lang);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var exportLangth = [1, 2];\r\n              $(\"#mainTable\").setupDataTable(url, colums, lang, urlAction,");
#nullable restore
#line 117 "D:\projects\Hospital\Web\Areas\Admin\Pages\CommonQuestions\Index.cshtml"
                                                                     Write(Model.length);

#line default
#line hidden
#nullable disable
                WriteLiteral(", exportLangth);\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CulutureServices CulutureServices { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Resource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Areas.Admin.Pages.CommonQuestions.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Areas.Admin.Pages.CommonQuestions.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Areas.Admin.Pages.CommonQuestions.IndexModel>)PageContext?.ViewData;
        public Web.Areas.Admin.Pages.CommonQuestions.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
