#pragma checksum "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e45183fdfb49e4fe46d168c12b7655304550cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
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
#line 1 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using DziennikTreningowy.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using DziennikTreningowy.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using DziennikTreningowy.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e45183fdfb49e4fe46d168c12b7655304550cfa", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8d26eba92ecb8d8a5ff120c92ace7f5eedc9aa", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e19ded7b40aa0c67bfa713e4a6d40a2dff614b6d", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Odmowa dostępu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">");
#nullable restore
#line 8 "C:\projektinz\DziennikTreningowy\UserManagement.MVC\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p class=\"text-danger\">Nie masz dostępu do tych danych.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591