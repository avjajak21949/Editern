#pragma checksum "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1097fc423523a4b870fece9510248981cf6aa844efcbd781e09797654e5799ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\_ViewImports.cshtml"
using E_learning.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\_ViewImports.cshtml"
using E_learning.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using E_learning.Areas.Identity.Pages.Account

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using E_learning.Areas.Identity.Pages.Account.Manage

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1097fc423523a4b870fece9510248981cf6aa844efcbd781e09797654e5799ea", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"16a38ce8824ea8bcb0e7268842bd46fcd9cd2f0484d2177c57770dce0686af60", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a5e164d57688bba0740b2271ff79b28e5a2e523daf17b8ca83d35b43a3e69dec", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"082f573d6403438ecb818f3bc1c69d76a579927c79578f44c66fec934317cc69", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData["ActivePage"] = "TwoFactorAuthentication";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1097fc423523a4b870fece9510248981cf6aa844efcbd781e09797654e5799ea5033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 8 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                    StatusMessage

#line default
#line hidden
#nullable disable
            );
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h4>");
            Write(
#nullable restore
#line 9 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <code class=\"recovery-code\">");
            Write(
#nullable restore
#line 22 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                         Model.RecoveryCodes[row]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code class=\"recovery-code\">");
            Write(
#nullable restore
#line 22 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                                                                                                        Model.RecoveryCodes[row + 1]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</code><br />\r\n");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\E-learning\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel>)PageContext?.ViewData;
        public ShowRecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
