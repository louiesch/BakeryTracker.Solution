#pragma checksum "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b98bbd28eb014036470cb7d19182eac5f552bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b98bbd28eb014036470cb7d19182eac5f552bc", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Add an order</h1>\n<p>Add a new order to ");
#nullable restore
#line 2 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/New.cshtml"
                 Write(Model.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<form");
            BeginWriteAttribute("action", " action=\"", 72, "\"", 112, 3);
            WriteAttributeValue("", 81, "/vendors/", 81, 9, true);
#nullable restore
#line 4 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/New.cshtml"
WriteAttributeValue("", 90, Model.VendorId, 90, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 105, "/orders", 105, 7, true);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\n  <input id =\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value = \"", 182, "\"", 207, 1);
#nullable restore
#line 5 "/Users/louiesch/Desktop/BakeryTracker.Solution/BakeryTracker/Views/Orders/New.cshtml"
WriteAttributeValue("", 192, Model.VendorId, 192, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
  <label for=""title"">Order title</label>
  <input id=""title"" name=""title"" type=""text"">
  <label for=""description"">Description of order</label>
  <input id=""description"" name=""description"" type=""text"">
  <label for=""date"">Order date</label>
  <input id=""date"" name=""date"" type=""text"">
  <label for=""price"">Price in dollars</label>
  <input id=""price"" name=""price"" type=""text"">
  <button type=""submit"">Add Item</button>
</form>

<p><a href=""/vendors"">Vendors</a></p>
<p><a href=""/"">Home Page</a></p>");
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