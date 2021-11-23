#pragma checksum "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b322606f7dc65a72e1d5e5659346eef74cc52cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_FormComponents_ContactGroupSelector__ContactGroupSelector), @"mvc.1.0.view", @"/Components/FormComponents/ContactGroupSelector/_ContactGroupSelector.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b322606f7dc65a72e1d5e5659346eef74cc52cc", @"/Components/FormComponents/ContactGroupSelector/_ContactGroupSelector.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    public class Components_FormComponents_ContactGroupSelector__ContactGroupSelector : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.FormComponents.ContactGroupSelectorComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
 if (Model.Items.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"contact-group-selector no-contact-groups\">");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
                                                      Write(HtmlLocalizer["No contact groups to select."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
 for (var index = 0; index < Model.Items.Count; index++)
{
    var item = Model.Items[index];


#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"contact-group-selector ktc-checkbox\">\r\n        <input type=\"checkbox\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 406, "\"", 471, 1);
#nullable restore
#line 15 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
WriteAttributeValue("", 427, Html.IdFor(x => Model.Items[index].Checked), 427, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n               name=\"", 472, "\"", 541, 1);
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
WriteAttributeValue("", 495, Html.NameFor(x => Model.Items[index].Checked), 495, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n               ");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
           Write(Model.Items[index].Checked ? "checked" : String.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               value=\"true\" />\r\n        <label");
            BeginWriteAttribute("for", " for=\"", 663, "\"", 714, 1);
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
WriteAttributeValue("", 669, Html.IdFor(x =>  Model.Items[index].Checked), 669, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
                                                              Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <input");
            BeginWriteAttribute("name", " name=\"", 757, "\"", 810, 1);
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
WriteAttributeValue("", 764, Html.NameFor(x => Model.Items[index].Checked), 764, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" value=\"false\" />\r\n    </span>\r\n");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
Write(Html.HiddenFor(x => x.Items[index].CodeName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
Write(Html.HiddenFor(x => x.Items[index].DisplayName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13_8_Azure\DancingGoatCore\Components\FormComponents\ContactGroupSelector\_ContactGroupSelector.cshtml"
                                                    

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.FormComponents.ContactGroupSelectorComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
