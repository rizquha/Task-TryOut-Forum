#pragma checksum "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10cdd891c17dae320b953b4f5c1de4815f162c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b10cdd891c17dae320b953b4f5c1de4815f162c0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a3b130df4f46d4256af3789a0b9092a407280e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "By DateTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "By Title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "By Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
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
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  padding: 16px;
  text-align: left;
  background-color: #FFFFFF;
}
</style>
<br><br><br><br>
<section class=""blog-post-area section-margin mt-4"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 sidebar-widgets"">
              <div class=""widget-wrap"">
                <div class=""single-sidebar-widget newsletter-widget"">
                  <h4 class=""single-sidebar-widget__title"">What Do You Want ?</h4>
                  <div class=""form-group mt-30"">
                    <di");
            WriteLiteral("v class=\"col-autos\">\r\n                      <select class=\"form-control\" id=\"select\">\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b10cdd891c17dae320b953b4f5c1de4815f162c05141", async() => {
                WriteLiteral("By DateTime");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b10cdd891c17dae320b953b4f5c1de4815f162c06331", async() => {
                WriteLiteral("By Title");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b10cdd891c17dae320b953b4f5c1de4815f162c07518", async() => {
                WriteLiteral("By Status");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                      </select>
                      <br>
                      <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Enter keyword"" onfocus=""this.placeholder = ''""
                        onblur=""this.placeholder = 'Enter email'"">
                    </div>
                  </div>
                  <button id=""searchsort"" class=""bbtns d-block mt-20 w-100"" onclick=""javascript:SearchSortButton(this)"">Search</button>
                </div>


                <div class=""single-sidebar-widget post-category-widget"">
                  <h4 class=""single-sidebar-widget__title"">Category</h4>
                  <ul class=""cat-list mt-20"">
");
#nullable restore
#line 61 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                    
                    var Category = ViewBag.category;
                    foreach(var i in Category)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <li>\r\n                        <input id=\"cat\"");
            BeginWriteAttribute("value", " value=\"", 2235, "\"", 2258, 1);
#nullable restore
#line 66 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
WriteAttributeValue("", 2243, ViewBag.filter, 2243, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2295, "\"", 2323, 2);
            WriteAttributeValue("", 2302, "/Home/Index?filter=", 2302, 19, true);
#nullable restore
#line 67 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
WriteAttributeValue("", 2321, i, 2321, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-flex justify-content-between\">\r\n                          <p>");
#nullable restore
#line 68 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </a>\r\n                      </li>\r\n");
#nullable restore
#line 71 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                    }
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </ul>\r\n                </div>\r\n              </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-8\">\r\n");
#nullable restore
#line 79 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                  
                    var threads = ViewBag.threads;
                    foreach(var i in threads)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-10"">
                                        <small><b>");
#nullable restore
#line 87 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                             Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> / <small class=\"text-muted\">");
#nullable restore
#line 87 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                                                                         Write(i.CreatedAt.ToString("dd-MM-yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        &nbsp&nbsp&nbsp\r\n");
#nullable restore
#line 89 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                         if(@i.Status=="Lock")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                          <img src=\"https://image.flaticon.com/icons/svg/483/483408.svg\" style=\"width: 10px;height:10px;\">\r\n");
#nullable restore
#line 92 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                        }else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                          <img src=\"https://image.flaticon.com/icons/svg/597/597356.svg\" style=\"width: 10px;height:10px;\">\r\n");
#nullable restore
#line 95 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </small>\r\n                                        <h4");
            BeginWriteAttribute("onclick", " onclick=\"", 3797, "\"", 3844, 3);
            WriteAttributeValue("", 3807, "location.href=\'/Home/Detail?id=", 3807, 31, true);
#nullable restore
#line 97 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
WriteAttributeValue("", 3838, i.Id, 3838, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3843, "\'", 3843, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                                                                       Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <small>");
#nullable restore
#line 98 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                                          Write(i.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small><br>\r\n                                    </div>\r\n                                    <div class=\"col-2\">\r\n                                        <div class=\"text-right\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4148, "\"", 4162, 1);
#nullable restore
#line 102 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
WriteAttributeValue("", 4154, i.Image, 4154, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 100px;height:100px;"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br>
");
#nullable restore
#line 109 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<div class=""bio-info collapse"" id=""profile"" aria-labelledby=""headingPage"" data-parent=""#accordionSidebar"">
		<div class=""row"">
			<div class=""col-md-6"">
				<div class=""row"">
					<div class=""col-md-12"">
						<div class=""bio-image"">
							<img style=""border-radius:50%;width:250px;height:300px;"" alt=""image"" />
						</div>			
					</div>
				</div>	
			</div>
			<div class=""col-md-6"">
				<div class=""bio-content"">
					<h1>Hi there, I'm </h1>
					<h6>Email : </h6>
					<h6>Gender : </h6>
					<h6>Phone : </h6>
					<h6>Birth  Date :</h6>
					<h6>Birth Place :</h6>
				</div>
			</div>
		</div>	
</div>
<script>
    function SearchSortButton(btn)
    {
      var x=document.getElementById(""cat"").value;
      if(x!=null || x!="""")
      {
        var filter = x;
        var sort = document.getElementById(""select"").value;
        var search = document.getElementById(""inlineFormInputGroup"").value;
        location.href='/H");
            WriteLiteral(@"ome/Index?search='+search+'&sort='+sort+'&filter='+filter;
        
      }else
      {
        var sort = document.getElementById(""select"").value;
        var search = document.getElementById(""inlineFormInputGroup"").value;
        location.href='/Home/Index?search='+search+'&sort='+sort;
      }
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
