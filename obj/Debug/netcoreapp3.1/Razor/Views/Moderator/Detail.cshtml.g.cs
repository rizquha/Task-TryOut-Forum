#pragma checksum "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a08697c3e6b3ce2384922dfb5ba4ae66d4aae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moderator_Detail), @"mvc.1.0.view", @"/Views/Moderator/Detail.cshtml")]
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
#line 1 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\_ViewImports.cshtml"
using Task_Try_Out_Forum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\_ViewImports.cshtml"
using Task_Try_Out_Forum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a08697c3e6b3ce2384922dfb5ba4ae66d4aae0", @"/Views/Moderator/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a3b130df4f46d4256af3789a0b9092a407280e", @"/Views/_ViewImports.cshtml")]
    public class Views_Moderator_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    * {
  box-sizing: border-box;
}

body {
  font-family: Arial, Helvetica, sans-serif;
}

/* Float four columns side by side */
.column {
  float: left;
  width: 25%;
  padding: 0 10px;
}

/* Remove extra left and right margins, due to padding */
.row {margin: 0 -5px;}

/* Clear floats after the columns */
.row:after {
  content: """";
  display: table;
  clear: both;
}
/* Style the counter cards */
.card {
  box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.1);
  padding: 16px;
  text-align: left;
  background-color: #FFFFFF;
}
</style>
");
#nullable restore
#line 34 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
  
    Layout="_LayoutModerator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br><br><br>
<section class=""blog-post-area section-margin mt-4"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 sidebar-widgets"">
              <div class=""widget-wrap"">
                <div class=""single-sidebar-widget post-category-widget"">
                  <h4 class=""single-sidebar-widget__title"">Thread Rekomendasi</h4>
                  <ul class=""cat-list mt-20"">
                    <li>
                        <div class=""container text-left"" style=""margin-left:0px;"">
                            <div class=""row"">
                                <div class=""col-8 text-left"">
                                    <p><b>etika menyalip bus di jalan tol</b></p>
                                    <p></p>
                                    <small class=""text-muted"">Sains & Technology</small>
                                </div>
                                <div class=""col-2"">
                                    <img src=""https://s.kaskus.id/i");
            WriteLiteral(@"mages/2019/06/01/7580643_201906011024150933.jpg"" style=""width:70px;height:70px;"">
                                </div>
                            </div>
                        </div>
                    </li>
                  </ul>
                </div>
              </div>
            </div>

            <div class=""col-lg-8"">
");
#nullable restore
#line 66 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                  
                    var detail = ViewBag.detail;
                    foreach(var i in detail)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card"">
                            <div class=""containe"">
                                <div class=""row"">
                                    <div class=""col-1"">
                                        <img src=""https://pngimage.net/wp-content/uploads/2018/06/inc-logo-png-4.png"" style=""width: 50px;height:50px;border-radius:50%;"">
                                    </div>
                                    <div class=""col-10"">
                                        <medium><b>");
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                                              Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> / <small class=\"text-muted\">");
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                                                                                          Write(i.CreatedAt.ToString("dd-MM-yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></medium>\r\n                                        <br>\r\n                                        <small class=\"text-muted\">");
#nullable restore
#line 79 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                                                             Write(i.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <hr class=\"mb-4\">\r\n                            <h4><b>");
#nullable restore
#line 84 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                              Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                            <div class=\"text-center\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3200, "\"", 3214, 1);
#nullable restore
#line 86 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
WriteAttributeValue("", 3206, i.Image, 3206, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:600px;height:400px;\">\r\n                            </div><br>\r\n                            <p>");
#nullable restore
#line 88 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                          Write(i.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <br>\r\n");
#nullable restore
#line 91 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Moderator\Detail.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
