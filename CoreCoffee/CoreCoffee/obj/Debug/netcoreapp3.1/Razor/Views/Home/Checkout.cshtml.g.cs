#pragma checksum "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7636cd41d2b4dab9874c8afc5ddce4b0b7edf219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7636cd41d2b4dab9874c8afc5ddce4b0b7edf219", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acfdd2983a1405cc5e4cabfb46581f1e24446dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreCoffee.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
  
    ViewBag.Title = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Checkout</h2>\r\n<p>Thank you for your order ");
#nullable restore
#line 7 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
                       Write(Model.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>We will give you a call at ");
#nullable restore
#line 9 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
                         Write(Model.Person.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" if there are any iusses with your order</p>\r\n<br />\r\n\r\n");
#nullable restore
#line 12 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
 if (Model.Delivery)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Your order will arrive at ");
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
                            Write(Model.Time.AddMinutes(30));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n");
#nullable restore
#line 16 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Your order will be ready for pickup at ");
#nullable restore
#line 19 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
                                         Write(Model.Time.AddMinutes(30));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n");
#nullable restore
#line 21 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Your current order is:</p>\r\n<ul>\r\n");
#nullable restore
#line 25 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
     foreach (var thing in Model.Stuff)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 27 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
       Write(thing.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
                   Write(thing.Drink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "C:\DevBuild4\WebApps\CoreCoffee\CoreCoffee\CoreCoffee\Views\Home\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreCoffee.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
