#pragma checksum "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b69323ea0e4a7d235ef49fe0429f9af1fb5af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b69323ea0e4a7d235ef49fe0429f9af1fb5af6", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Bakery Tracker Order Details: </h1>\n\n<h2>Vendor: ");
#nullable restore
#line 3 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
       Write(Model["vendor"].VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>Order title: ");
#nullable restore
#line 4 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
            Write(Model["order"].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>Order description: ");
#nullable restore
#line 5 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
                  Write(Model["order"].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h3>Date ordered: ");
#nullable restore
#line 6 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
             Write(Model["order"].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>Order total: ");
#nullable restore
#line 7 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
            Write(Model["order"].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<a");
            BeginWriteAttribute("href", " href=\'", 277, "\'", 328, 3);
            WriteAttributeValue("", 284, "/vendors/", 284, 9, true);
#nullable restore
#line 9 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 293, Model["vendor"].orderId, 293, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 317, "/orders/new", 317, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Add another order</a>\n<a href=\'/vendors/orders\'>View all orders</a>\n<a href=\'/vendors\'>View all vendors</a>\n<a href=\'/\'>Home Page</a>");
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