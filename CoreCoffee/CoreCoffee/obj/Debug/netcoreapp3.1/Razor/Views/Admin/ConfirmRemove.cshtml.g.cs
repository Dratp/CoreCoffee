#pragma checksum "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df27ea8939e68269de2ca8781691b0eeb417fdbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ConfirmRemove), @"mvc.1.0.view", @"/Views/Admin/ConfirmRemove.cshtml")]
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
#line 1 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\_ViewImports.cshtml"
using CoreCoffee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\_ViewImports.cshtml"
using CoreCoffee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df27ea8939e68269de2ca8781691b0eeb417fdbe", @"/Views/Admin/ConfirmRemove.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acfdd2983a1405cc5e4cabfb46581f1e24446dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ConfirmRemove : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
  
    ViewData["Title"] = "ConfirmRemove";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Confirm Remove</h2>\r\n<br />\r\n<p>Category: ");
#nullable restore
#line 8 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
        Write(Model.Product_Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Name: ");
#nullable restore
#line 9 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
    Write(Model.Product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Price: ");
#nullable restore
#line 10 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
     Write(Model.Product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Description: ");
#nullable restore
#line 11 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
           Write(Model.Product_Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<li>Are you sure you want to Delete this item?</li>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 324, "\"", 366, 2);
            WriteAttributeValue("", 331, "/Admin/Remove?pid=", 331, 18, true);
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Admin\ConfirmRemove.cshtml"
WriteAttributeValue("", 349, Model.Product_id, 349, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Yes</a><br />\r\n<a href=\"/Admin/InventoryControl\">No</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
