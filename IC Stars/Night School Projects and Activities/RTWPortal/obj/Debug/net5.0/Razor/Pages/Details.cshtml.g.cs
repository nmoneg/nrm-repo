#pragma checksum "D:\Docs\2020\ic stars\NSC47\RTWPortal\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb2ff39ac91c8300195c37e67087949f5aad6269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RTWPortal.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace RTWPortal.Pages
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
#line 1 "D:\Docs\2020\ic stars\NSC47\RTWPortal\Pages\_ViewImports.cshtml"
using RTWPortal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2ff39ac91c8300195c37e67087949f5aad6269", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d0af545b147158058eea4817665ae1374a2e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Docs\2020\ic stars\NSC47\RTWPortal\Pages\Details.cshtml"
  
    ViewData["Title"] = "Office Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #details {
        border-style: solid;
        border-width: 1px;
        border-radius: 20px;
        border-color: #596773;
        color: #596773;
        position: relative;
        top: 100px;
        padding: 10px;
    }
    
</style>


<div class=""text-center"" style=""margin-top:30px"">
        <h1 class=""display-4"">Office Details</h1>   
</div>

    <div id=""details"">
        
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <ul style=""list-style-type:none;"">
                        <li><h3>[OFFICE NAME]</h3></li>
                        <li><h6>[LOCATION TAGS]</li>
                        <li><br><br><h5>[STATUS]</h5></li>
                        <li><br><strong>Region:</strong>    [REGION]</li>
                        <li><br><strong>Address:</strong><br>[ADDRESS]</li>
                    </ul>
                </div>
                <div class=""col-sm-8"">
                    <ul styl");
            WriteLiteral(@"e=""list-style-type:none;"">
                        <li><strong>Office Services:</strong>   [Text]</li>
                        <li><strong>Visitors Allowed:</strong>   [Text]</li>
                        <li><strong>Face Coverings:</strong> [Text]</li>
                        <li><strong>Temperature Checks:</strong> [Text]</li>
                        <li><strong>Special Considerations:</strong> [Text]</li>
                        <li><strong>Special Consideration Details:</strong> [Test text test text test text test text test text test text test text ]</li>
                        <li><strong>Tech Support:</strong> [Text]</li>
                        <li><strong>Dress Code:</strong> [Text]</li>
                        <li><strong>Additional Information:</strong> [Test text test text test text test text test text test text test text ]</li>
                        <li><br><br><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"">Export</button></li>
                    </ul>
            ");
            WriteLiteral("    </div>\r\n            </div>\r\n        </div>     \r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel>)PageContext?.ViewData;
        public DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591