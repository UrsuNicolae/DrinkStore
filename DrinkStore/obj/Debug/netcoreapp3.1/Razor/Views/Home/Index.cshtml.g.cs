#pragma checksum "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7558366e7fb5d17c0aab772dfddaada544794c42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\_ViewImports.cshtml"
using DrinkStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\_ViewImports.cshtml"
using DrinkStore.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7558366e7fb5d17c0aab772dfddaada544794c42", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576981b108906d8acd7ec8f7a02edd41d7652d46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n    ");
#nullable restore
#line 3 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Prefered drinks of the week</h2>\r\n    <h4>Clients preferences - just for you!</h4>\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Home\Index.cshtml"
             foreach (var drink in Model.PreferredDrinks)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Home\Index.cshtml"
           Write(Html.Partial("DrinkSummary", drink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Home\Index.cshtml"
                                                    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
