#pragma checksum "D:\Docs\2020\ic stars\NSC47\RTWPortal\Pages\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e5f96ef88ba3e8d0453d044a7aef240fbe1015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RTWPortal.Pages.Pages_Feedback), @"mvc.1.0.razor-page", @"/Pages/Feedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e5f96ef88ba3e8d0453d044a7aef240fbe1015", @"/Pages/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d0af545b147158058eea4817665ae1374a2e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Feedback : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Docs\2020\ic stars\NSC47\RTWPortal\Pages\Feedback.cshtml"
  
    ViewData["Title"] = "Feedback";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    
.radio-emoji {
  position: absolute;
  left: -9999px;
}

.radio-emoji + label {
  font-size: 20px;  
  padding: 6px;
  border-radius: 4px; 
}

.radio-emoji + label:hover {
  cursor: pointer;
  background-color: #e0e0e0;
}

.radio-emoji:checked + label {
  background-color: #e0e0e0; 
}

.label-emoji.inactive {
  opacity: 0.25;

}
.container {
padding: 50px;

}
</style>

<
  <div class=""text-center"" style=""margin-top:30px"">

        <h2>We Would Like Your Feedback</h2>   
</div>
<div class=""text-center"" Style=""margin-top:20px"">
            <h3><strong>How was your experience ?</strong></h3><br>
            <p><strong>Please select Your Feedback Category below:</strong></p>
    <div class=""container"">
        <div class=""feedback-rating-scale"">

        <input type=""radio"" class=""radio-emoji"" name=""radio-emoji"" id=""emoji-1"" value=""1"">
        <label class=""label-emoji"" for=""emoji-1"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Bad"">😡</label>Bad &n");
            WriteLiteral(@"bsp; &nbsp; 

        <input type=""radio"" class=""radio-emoji"" name=""radio-emoji"" id=""emoji-2"" value=""2"">
        <label class=""label-emoji"" for=""emoji-2"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Below Average"">🙁</label> Below Average &nbsp; &nbsp; 

        <input type=""radio"" class=""radio-emoji"" name=""radio-emoji"" id=""emoji-3"" value=""3"">
        <label class=""label-emoji"" for=""emoji-3"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Average"">😐</label> Average &nbsp; &nbsp; 

        <input type=""radio"" class=""radio-emoji"" name=""radio-emoji"" id=""emoji-4"" value=""4"">
        <label class=""label-emoji"" for=""emoji-4"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Very Good"">🙂</label> Very Good &nbsp; &nbsp; 

        <input type=""radio"" class=""radio-emoji"" name=""radio-emoji"" id=""emoji-5"" value=""5"">
        <label class=""label-emoji"" for=""emoji-5"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Excellent"">😍</label> Excellent &nbsp; &nbsp; 
    
        </div>
    </di");
            WriteLiteral(@"v>
        <div>
              <label for=""feedback""></label><br>
              <textarea name=""Feedback"" id=""Feedback"" cols=""40"" rows=""5"" placeholder=""Leave Additional Comments Here""></textarea>
              <br><br><button type=""button"" id=""purple"" class=""btn btn-primary btn-lg"">Submit</button>
            </div>
        </div>    
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FeedbackModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FeedbackModel>)PageContext?.ViewData;
        public FeedbackModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591