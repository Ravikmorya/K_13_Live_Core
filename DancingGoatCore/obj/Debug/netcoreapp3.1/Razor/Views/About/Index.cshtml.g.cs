#pragma checksum "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46de2e476a3c76522a35ed71652de968818ce9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46de2e476a3c76522a35ed71652de968818ce9b8", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.AboutUsViewModel>
    {
        private global::AspNetCore.Views_About_Index.__Generated__MediaGalleryViewComponentTagHelper __MediaGalleryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Reference", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
  
    bool DisplayInRight(int sequenceOrder)
    {
        return sequenceOrder % 2 != 0;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"about-page\">\r\n");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
     for (int i = 0; i < Model.Sections.Count; i++)
    {
        var aboutSection = Model.Sections[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"row text-and-image\">\r\n            <h2 class=\"col-lg-12\">");
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
                             Write(aboutSection.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 414, "\"", 497, 3);
            WriteAttributeValue("", 422, "col-md-6", 422, 8, true);
            WriteAttributeValue(" ", 430, "col-xl-8", 431, 9, true);
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue(" ", 439, DisplayInRight(i) ? "col-md-push-6 col-xl-push-4" : "", 440, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 521, "\"", 589, 2);
            WriteAttributeValue("", 529, "text-and-image-text", 529, 19, true);
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue(" ", 548, DisplayInRight(i) ? "text-right" : "", 549, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
               Write(Html.Raw(aboutSection.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 703, "\"", 786, 3);
            WriteAttributeValue("", 711, "col-md-6", 711, 8, true);
            WriteAttributeValue(" ", 719, "col-xl-4", 720, 9, true);
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue(" ", 728, DisplayInRight(i) ? "col-md-pull-6 col-xl-pull-8" : "", 729, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
                 if (!string.IsNullOrEmpty(aboutSection.ImagePath))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 902, "\"", 931, 1);
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue("", 908, aboutSection.ImagePath, 908, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 932, "\"", 959, 1);
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue("", 938, aboutSection.Heading, 938, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 960, "\"", 989, 1);
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
WriteAttributeValue("", 968, aboutSection.Heading, 968, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n");
#nullable restore
#line 27 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n");
#nullable restore
#line 30 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"

        if (i == 0 && Model.Reference != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46de2e476a3c76522a35ed71652de968818ce9b89093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Reference;

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
#line 34 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Views\About\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:media-gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46de2e476a3c76522a35ed71652de968818ce9b810884", async() => {
            }
            );
            __MediaGalleryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_About_Index.__Generated__MediaGalleryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__MediaGalleryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.AboutUsViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:media-gallery")]
        public class __Generated__MediaGalleryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__MediaGalleryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("MediaGallery", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
