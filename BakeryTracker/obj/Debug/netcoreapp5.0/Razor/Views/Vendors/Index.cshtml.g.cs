#pragma checksum "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41785bec0d9b407989927f1c5afd1623f846381e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
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
#line 1 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
using BakeryTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41785bec0d9b407989927f1c5afd1623f846381e", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Vendors</h1>\n\n");
#nullable restore
#line 5 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No vendors have been added yet!</h3>\n");
#nullable restore
#line 8 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3><a");
            BeginWriteAttribute("href", " href=\"", 165, "\"", 197, 2);
            WriteAttributeValue("", 172, "/vendors/", 172, 9, true);
#nullable restore
#line 12 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
WriteAttributeValue("", 181, vendor.VendorId, 181, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
                                     Write(vendor.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n");
#nullable restore
#line 13 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Vendors/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p><a href=\"/vendors/new\">Add a new vendor</a></p>\n<p><a href=\'/\'>Home Page</a></p>");
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
