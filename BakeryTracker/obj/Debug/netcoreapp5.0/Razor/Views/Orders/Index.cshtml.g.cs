#pragma checksum "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f688fb19e8c4b72ad5df7191e68cf57b7647a55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
using BakeryTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f688fb19e8c4b72ad5df7191e68cf57b7647a55", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Orders</h1>\n\n");
#nullable restore
#line 5 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No orders have been added yet!</h3>\n");
#nullable restore
#line 8 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
 foreach (Order order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>");
#nullable restore
#line 12 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
 Write(order.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 13 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p><a href=\"/vendors/\">Add an order to an existing vendor</a></p>\n<p><a href=\"/vendors/new\">Add a new vendor</a></p>\n<p><a href=\'/\'>Home Page</a></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591