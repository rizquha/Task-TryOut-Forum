#pragma checksum "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d857206cdd78d7a437f9e61ff52a8b151c79422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_ListUser), @"mvc.1.0.view", @"/Views/Administrator/ListUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d857206cdd78d7a437f9e61ff52a8b151c79422", @"/Views/Administrator/ListUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a3b130df4f46d4256af3789a0b9092a407280e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_ListUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Moderator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    #customers {
  font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#customers td, #customers th {
  border: 1px solid #ddd;
  padding: 8px;
}

#customers tr:nth-child(even){background-color: #f2f2f2;}

#customers tr:hover {background-color: #ddd;}

#customers th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
</style>
");
#nullable restore
#line 25 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
  
    Layout="_LayoutAdministrator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br><br><br>
<button class=""btn btn-info"" data-toggle=""modal"" data-target=""#exampleModal"">Add User</button>
<br>
<table id=""customers"">
  <tr>
    <th>No</th>
    <th>Name</th>
    <th>Role</th>
    <th>Change Role</th>
    <th>Status</th>
  </tr>
");
#nullable restore
#line 39 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
    
      var counter=0;
      var member = ViewBag.member;
      foreach(var i in member)
      {
          counter+=1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 46 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
           Write(i.Nama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
           Write(i.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 50 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
               if(@i.Role=="Member")
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <select id=\"select-Member\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c794226415", async() => {
                WriteLiteral("Moderator");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c794227593", async() => {
                WriteLiteral("Administrator");
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
            WriteLiteral("\r\n              </select>\r\n              <br>\r\n              <button");
            BeginWriteAttribute("id", " id=\"", 1350, "\"", 1367, 2);
#nullable restore
#line 57 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 1355, i.Id, 1355, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1360, "-Member", 1360, 7, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript : ChangeRole(this)\" class=\"btn btn-info text-center\">Save</button>\r\n");
#nullable restore
#line 58 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
              }else if(@i.Role=="Moderator")
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <select id=\"select-Moderator\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c794229691", async() => {
                WriteLiteral("Member");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942210866", async() => {
                WriteLiteral("Administrator");
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
            WriteLiteral("\r\n              </select>\r\n              <br>\r\n              <button");
            BeginWriteAttribute("id", " id=\"", 1779, "\"", 1799, 2);
#nullable restore
#line 65 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 1784, i.Id, 1784, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1789, "-Moderator", 1789, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1800, "\"", 1813, 1);
#nullable restore
#line 65 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 1808, i.Id, 1808, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-center\" onclick=\"javascript : ChangeRole(this)\">Save</button>\r\n");
#nullable restore
#line 66 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
              }else if(@i.Role=="Administrator")
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <select id=\"select-Administrator\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942213304", async() => {
                WriteLiteral("Member");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942214480", async() => {
                WriteLiteral("Moderator");
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
            WriteLiteral("\r\n              </select>\r\n              <br>\r\n              <button");
            BeginWriteAttribute("id", " id=\"", 2225, "\"", 2249, 2);
#nullable restore
#line 73 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 2230, i.Id, 2230, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2235, "-Administrator", 2235, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2250, "\"", 2263, 1);
#nullable restore
#line 73 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 2258, i.Id, 2258, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript : ChangeRole(this)\" class=\"btn btn-info text-center\">Save</button>\r\n");
#nullable restore
#line 74 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n");
#nullable restore
#line 76 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
             if(@i.Role=="Member")
            {
              

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
               if(@i.Ban==true)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-center\">Banned\r\n                  <br>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2589, "\"", 2650, 3);
            WriteAttributeValue("", 2599, "location.href=\'/Administrator/UnbanMember?id=", 2599, 45, true);
#nullable restore
#line 82 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 2644, i.Id, 2644, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2649, "\'", 2649, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Unban This Member</button>\r\n                </td>\r\n");
#nullable restore
#line 84 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
              }else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-center\">No Banned\r\n                  <br>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2864, "\"", 2923, 3);
            WriteAttributeValue("", 2874, "location.href=\'/Administrator/BanMember?id=", 2874, 43, true);
#nullable restore
#line 88 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
WriteAttributeValue("", 2917, i.Id, 2917, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2922, "\'", 2922, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Ban This Member</button>\r\n                </td>\r\n");
#nullable restore
#line 90 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
               
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <td class=\"text-center\">Always Active</td>\r\n");
#nullable restore
#line 95 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 97 "D:\Users\bsi50129\.vscode\Task Try Out Forum\Views\Administrator\ListUser.cshtml"
      }
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
</table>
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Add User</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <label>Name</label>
        <input class=""form-control"" type=""text"" id=""name"">
        <br>
        <label>Email</label>
        <input class=""form-control"" type=""text"" id=""email"">
        <br>
        <label>Password</label>
        <input class=""form-control"" type=""text"" id=""pass"">
        <br>
        <label>Email</label>
        <select class=""form-control"" id=""selectadd"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942220864", async() => {
                WriteLiteral("Member");
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
            WriteLiteral("\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942222034", async() => {
                WriteLiteral("Moderator");
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
            WriteLiteral("\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d857206cdd78d7a437f9e61ff52a8b151c7942223207", async() => {
                WriteLiteral("Administrator");
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
            WriteLiteral(@"
        </select>
        <br>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary""onclick=""javascript : SaveAdd(this)"">Save</button>
      </div>
    </div>
  </div>
</div>
<script>
  function ChangeRole(btn)
  {
    var id = btn.id;
    var split = id.split(""-"");
    var val = split[1];
    var idselect = ""select-""+val;
    var select = document.getElementById(idselect).value;
    var iduser = split[0];
    console.log(split);
    console.log(iduser);
    console.log(split[0]);
    location.href='/Administrator/ChangeRole?id='+iduser+'&role='+select;
  }
  function SaveAdd(btn)
  {
    var name = document.getElementById(""name"").value;
    var email = document.getElementById(""email"").value;
    var pass = document.getElementById(""pass"").value;
    var selectadd = document.getElementById(""selectadd"").value;
    location.href='/Administrator/");
            WriteLiteral("AddUser?name=\'+name+\'&email=\'+email+\'&pass=\'+pass+\'&selectadd=\'+selectadd;\r\n\r\n  }\r\n</script>");
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
