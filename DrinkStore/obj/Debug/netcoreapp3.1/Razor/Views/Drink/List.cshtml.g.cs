#pragma checksum "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e9d2ccfa0a23ebd7031675a1600d9981f49e14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e9d2ccfa0a23ebd7031675a1600d9981f49e14", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113e02cedea3d012548af3988406247021170436", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrinkListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml"
  
    ViewBag.Title = "DrinkStore";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>All available drinks</h2>\r\n</div>\r\n<div>\r\n    <h2>");
#nullable restore
#line 11 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n\r\n<div class=\"row marginTop\">\r\n");
#nullable restore
#line 15 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml"
      
        foreach (Drink drink in Model.Drinks)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml"
       Write(Html.Partial("DrinkSummary", drink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\colea\Desktop\DrinkStore\DrinkStore\Views\Drink\List.cshtml"
                                                
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrinkListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591