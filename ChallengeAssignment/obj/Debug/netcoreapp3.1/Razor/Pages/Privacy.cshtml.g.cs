#pragma checksum "C:\Users\Ricar\Documents\GitHub\TTA_Basic_C_Sharp_projects\ChallengeAssignment\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4bf93727d777506a7655064c850f7d2cab9b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChallengeAssignment.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace ChallengeAssignment.Pages
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
#line 1 "C:\Users\Ricar\Documents\GitHub\TTA_Basic_C_Sharp_projects\ChallengeAssignment\Pages\_ViewImports.cshtml"
using ChallengeAssignment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4bf93727d777506a7655064c850f7d2cab9b94", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc9cc3e73755b9440c375cb12eb776e74ef2288", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ricar\Documents\GitHub\TTA_Basic_C_Sharp_projects\ChallengeAssignment\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Ricar\Documents\GitHub\TTA_Basic_C_Sharp_projects\ChallengeAssignment\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h2>The current date and time is ");
#nullable restore
#line 8 "C:\Users\Ricar\Documents\GitHub\TTA_Basic_C_Sharp_projects\ChallengeAssignment\Pages\Privacy.cshtml"
                            Write(ViewData["TimeStamp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<br />
<h3>DateTime Property</h3>
<p>DateTime is a data type object, the DateTime with the property .Now and the method .ToLocalTime is displayed above</p>
<br />
<h3>Event Handlers</h3>
<p>In Razor pages, like the one you are seeing now, handler methods are executed as a result of request. The date and time
   displayed above is using the onGet() method.</p>
<br />
<h3>Void Method</h3>
<p>A void method does return any value, and can used without any datatype after the return statement. The method used
  to display the date and time above is using a void method</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
