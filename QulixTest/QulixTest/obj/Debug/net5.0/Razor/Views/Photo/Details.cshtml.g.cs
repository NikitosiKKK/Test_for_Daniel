#pragma checksum "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dea9d9b53644338338f6af231cd610533896b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_Details), @"mvc.1.0.view", @"/Views/Photo/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dea9d9b53644338338f6af231cd610533896b89", @"/Views/Photo/Details.cshtml")]
    #nullable restore
    public class Views_Photo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BLL.Models.PhotoModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
  
    ViewData["Title"] = "Список Фотографий";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<p>
    <a asp-controller=""Photo"" asp-action=""Create"">Добавить</a>
</p>
<table class=""table"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Url</th>
<th>Size</th>
<th>Date of creation</th>
<th>Price</th>
<th>Purchases</th>
<th>Rating</th>
    </tr>
 
    
    {
        <tr>
            <td>");
#nullable restore
#line 24 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
           Write(Model.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td>");
#nullable restore
#line 25 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td>");
#nullable restore
#line 26 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td>");
#nullable restore
#line 27 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                ");
#nullable restore
#line 29 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
           Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n<td>");
#nullable restore
#line 31 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td>");
#nullable restore
#line 32 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Purchases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n<td>");
#nullable restore
#line 33 "D:\works\qulix-test-main\QulixTest\QulixTest\Views\Photo\Details.cshtml"
Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            \n        </tr>\n    }\n</table>\n<a href=\"https://localhost:44346/api/photo\">\n<input type=\"button\" value=\"Back\">\n</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BLL.Models.PhotoModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
