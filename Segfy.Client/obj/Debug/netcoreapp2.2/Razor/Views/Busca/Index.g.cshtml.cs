#pragma checksum "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b3febf2ec3fe06180b08e1232bf3ff139bfa8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Busca_Index), @"mvc.1.0.view", @"/Views/Busca/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Busca/Index.cshtml", typeof(AspNetCore.Views_Busca_Index))]
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
#line 1 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\_ViewImports.cshtml"
using Segfy.Client;

#line default
#line hidden
#line 2 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\_ViewImports.cshtml"
using Segfy.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b3febf2ec3fe06180b08e1232bf3ff139bfa8c", @"/Views/Busca/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb57ebc67fd5beb7107533cfe2f9e33816d64ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Busca_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Segfy.Shared.Models.Seguro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
  
    ViewData["Title"] = "Resultado da Pesquisa";

#line default
#line hidden
            BeginContext(107, 131, true);
            WriteLiteral("\r\n<h1>Resultado da Pesquisa</h1>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(239, 52, false);
#line 15 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClienteDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(291, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 46, false);
#line 18 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SeguroTipo));

#line default
#line hidden
            EndContext();
            BeginContext(393, 57, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 46, false);
#line 22 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SeguroItem));

#line default
#line hidden
            EndContext();
            BeginContext(497, 65, true);
            WriteLiteral("\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(611, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(672, 51, false);
#line 32 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ClienteDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(723, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(791, 45, false);
#line 35 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SeguroTipo));

#line default
#line hidden
            EndContext();
            BeginContext(836, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(904, 45, false);
#line 38 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SeguroItem));

#line default
#line hidden
            EndContext();
            BeginContext(949, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1004, 197, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<style>\r\n    .deletar {\r\n        color: red;\r\n        cursor: pointer;\r\n    }\r\n\r\n        .deletar:hover {\r\n            text-decoration: underline;\r\n        }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(1201, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b3febf2ec3fe06180b08e1232bf3ff139bfa8c7554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1252, 314, true);
            WriteLiteral(@"
<script>
    $("".deletar"").click(function () {

        var thisElement = $(this);
        var thisId = thisElement.data(""id"");
        console.log(thisId);

        if (window.confirm(""Deseja realmente deletar esse Seguro?"")) {
            $.ajax({
                type: 'POST',
                url: '");
            EndContext();
            BeginContext(1567, 30, false);
#line 67 "C:\Users\Dev\Dropbox\Dev\Segfy\VisualStudio\SegfyCore\Segfy.Client\Views\Busca\Index.cshtml"
                 Write(Url.Action("Delete", "Seguro"));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 532, true);
            WriteLiteral(@"',
                data: { id: thisId },

                error: function (jqXHR, textStatus, errorThrown) {
                    alert(""Erro ao deletar seguro"");
                },

                success: function (data, textStatus, jqXHR) {
                    if($.trim(data))
                    {
                        alert(""Seguro deletado com sucesso!"");
                        thisElement.parent().parent().remove();
                    }
                }
            });
        }
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Segfy.Shared.Models.Seguro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
