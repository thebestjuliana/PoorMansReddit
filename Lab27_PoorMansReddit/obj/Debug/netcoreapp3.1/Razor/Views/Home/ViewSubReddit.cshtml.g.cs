#pragma checksum "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abb1fb38c1cda18f5d7e22964cd9beb411ef10b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewSubReddit), @"mvc.1.0.view", @"/Views/Home/ViewSubReddit.cshtml")]
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
#line 1 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\_ViewImports.cshtml"
using Lab27_PoorMansReddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\_ViewImports.cshtml"
using Lab27_PoorMansReddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb1fb38c1cda18f5d7e22964cd9beb411ef10b7", @"/Views/Home/ViewSubReddit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb5646371c19dfca98e34eb60f6bb82ca93227e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewSubReddit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubReddit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
 foreach (var item in Model.data.children.ToList())
{
    
  

        string link = "https://www.reddit.com" + item.data.permalink;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 10 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
       Write(item.data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 206, "\"", 218, 1);
#nullable restore
#line 11 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
WriteAttributeValue("", 213, link, 213, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
                   Write(item.data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <br />\r\n        <p>");
#nullable restore
#line 13 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
      Write(item.data.selftext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n");
#nullable restore
#line 15 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
        if (item.data.thumbnail != "self")
        {


            if (item.data.is_video)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <video controls=\"controls\"");
            BeginWriteAttribute("src", " src=\"", 465, "\"", 513, 1);
#nullable restore
#line 22 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
WriteAttributeValue("", 471, item.data.media.reddit_video.fallback_url, 471, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\">\r\n                    Your browser does not support the HTML5 Video element.\r\n                </video>\r\n                <br />\r\n");
#nullable restore
#line 26 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"

            }
            else if (item.data.url.EndsWith(".html") || item.data.url.Contains(".com"))
            {

            }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 848, "\"", 868, 1);
#nullable restore
#line 35 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
WriteAttributeValue("", 854, item.data.url, 854, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 869, "\"", 890, 1);
#nullable restore
#line 35 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"
WriteAttributeValue("", 875, item.data.name, 875, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"700\">\r\n                <br />\r\n");
#nullable restore
#line 37 "C:\Users\sheeh\source\repos\Lab27_PoorMansReddit\Lab27_PoorMansReddit\Views\Home\ViewSubReddit.cshtml"

            }
          
        
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubReddit> Html { get; private set; }
    }
}
#pragma warning restore 1591
