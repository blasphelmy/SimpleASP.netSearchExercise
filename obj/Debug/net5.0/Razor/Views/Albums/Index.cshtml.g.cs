#pragma checksum "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f513e61e68248aae6fbd51622fe5b9569edd80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
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
#line 1 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/_ViewImports.cshtml"
using CSI250Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/_ViewImports.cshtml"
using CSI250Lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f513e61e68248aae6fbd51622fe5b9569edd80", @"/Views/Albums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd003a3dda4d7fea6c4090588ca56ffb79ec9d04", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Album>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("onPriceChange()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
  
    ViewData["Title"] = "Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
var urlParameters = new Map();
window.onload = function(){
    document.getElementById(""searchButton"").addEventListener(""click"", function(){
        let URL = parseIntoUrl(getSearchTerm())
        window.location.href = URL;
    });
    var headers = document.getElementsByClassName(""albumHeaders"");
    for(header of headers){
        header.addEventListener(""click"", function(){
            window.location.href = ""?price="" + urlParameters.get(""price"") + ""&sort="" + this.id;
        })
    }
}
function onPriceChange(){
        window.location.href = ""?price=""+document.getElementById(""sel"").value + ""&sort="" + urlParameters.get(""sort"");
}
function parseIntoUrl(searchString){
    return ""Albums/Search?term="" + searchString;
}
function getSearchTerm(){
    return JSON.stringify(document.getElementById(""searchbox"").value);
}
</script>
<br><br><br>
<div class=""form-group"">
    <label class=""control-label"">Filter by Price</label>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4f513e61e68248aae6fbd51622fe5b9569edd805228", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SelectListPrices;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <span class=""text-danger""></span>
</div>
<script>
var options = document.getElementsByTagName(""option"");
function extractURLParems(){
    urlParameters.set(""price"", ""0"");
    urlParameters.set(""sort"", ""0"");
    try{
        let parameters = window.location.href.split(""?"")[1].split(""&"");
        for(parameter of parameters){
            let keyValue = parameter.split(""="");
            urlParameters.set(keyValue[0], keyValue[1]);
        }
    }catch(error){
        console.log(error);
    }
    console.log(urlParameters);
}
extractURLParems();
for(option of options){
    if(option.value == urlParameters.get(""price"")){
        option.selected = ""selected"";
    }
}

</script>
<table class=""table table-responsive table-striped"">
    <tr>
        <th><a id=""1"" class=""albumHeaders"">ID</a></th>
        <th><a id=""4"" class=""albumHeaders"">Title</a></th>
        <th><a id=""3"" class=""albumHeaders"">Artist</a></th>
        <th><a id=""5"" class=""albumHeaders"">Genre</a></th>
        <th>");
            WriteLiteral("<a id=\"2\" class=\"albumHeaders\">Price</a></th>\r\n    </tr>\r\n");
#nullable restore
#line 67 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
     foreach(Album album in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>");
#nullable restore
#line 70 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
           Write(album.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 71 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
           Write(album.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 72 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
           Write(album.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 73 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
           Write(album.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
           Write(album.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "/Users/davidnguyen/Desktop/CSI 250/CSI250Lab3/Views/Albums/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<script>\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591