#pragma checksum "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5caefffe75f4dad24a51f6e4d12d614d93d8a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shortlist_Index), @"mvc.1.0.view", @"/Views/Shortlist/Index.cshtml")]
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
#line 1 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\_ViewImports.cshtml"
using Jobbply__Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\_ViewImports.cshtml"
using Jobbply__Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5caefffe75f4dad24a51f6e4d12d614d93d8a9", @"/Views/Shortlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b880dbdf7d60f0f3d935e800be6e7f59cae8367", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shortlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShortlistVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <!-- MAIN START -->

   <main>
    <!-- Small introductory part -->
   <section id=""canditates"">
     <div class=""container"">
       <div class=""row"">
         <div class=""col-lg-6 col-md-12 mb-6"">
           <div class=""text-block p-5"">
             <div class=""content"">
               <span class=""subtitle"">");
#nullable restore
#line 17 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                 Write(Model.about.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa-solid fa-angle-right\"></i></span>\r\n               <span class=\"title\"> ");
#nullable restore
#line 18 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                               Write(Model.about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n               <h1>");
#nullable restore
#line 19 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
              Write(Model.about.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
              
             </div>
           </div>
         </div>
       </div>
      </div>
   </section>

   <section id=""shortlist"">
    <div class=""shortlist-layer bg-light"">
      <div class=""container"">
        <div class=""row d-flex"">
");
#nullable restore
#line 32 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
           foreach (var item in Model.shortlists)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-lg-6 col-md-12 col-mb-6\">\r\n            <div class=\"team \">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 1034, "\"", 1077, 2);
            WriteAttributeValue("", 1040, "./assets/image/canditates/", 1040, 26, true);
#nullable restore
#line 36 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
WriteAttributeValue("", 1066, item.Image, 1066, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1078, "\"", 1084, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <div class=\"text\">\r\n                        <h3 class=\"name\">");
#nullable restore
#line 38 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h5 class=\"position\">");
#nullable restore
#line 39 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                        Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5 class=\"graduate\">");
#nullable restore
#line 40 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                        Write(item.Graduate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h6 class=\"awards\">");
#nullable restore
#line 41 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                      Write(item.Awards);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 42 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                      Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h6 class=\"activity\">");
#nullable restore
#line 43 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                        Write(item.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6 class=\"city\">");
#nullable restore
#line 44 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
                                    Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        \r\n                      </div>\r\n            </div>\r\n\r\n          </div>\n");
#nullable restore
#line 50 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\Shortlist\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n        </div>\r\n      </div>\r\n    </div>\r\n   </section>\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShortlistVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
