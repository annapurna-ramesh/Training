#pragma checksum "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24d6aa63f8765a1d7346d4da8ce1601df1397af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\_ViewImports.cshtml"
using HandsOnMVCUsingViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\_ViewImports.cshtml"
using HandsOnMVCUsingViewModel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24d6aa63f8765a1d7346d4da8ce1601df1397af9", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2a887701313b28f31b5ff8f136f41caecbe147", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HandsOnMVCUsingViewModel.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<a href=\"Product/Create\">Create</a>\n<div class=\"container\">\n    <table class=\"table table-bordered\">\n        <tr>\n            <th>ID</th><th>Name</th><th>Price</th><th>Stocks</th>\n        </tr>\n");
#nullable restore
#line 13 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
         if (Model.Count != 0)
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n             <td>");
#nullable restore
#line 18 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
            Write(item.Pid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n              <td>");
#nullable restore
#line 19 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
             Write(item.Pname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 23 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\socgend31\Downloads\SOCGEN-master\Day3\HandsOnMVCUsingViewModel\HandsOnMVCUsingViewModel\Views\Product\Index.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HandsOnMVCUsingViewModel.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591