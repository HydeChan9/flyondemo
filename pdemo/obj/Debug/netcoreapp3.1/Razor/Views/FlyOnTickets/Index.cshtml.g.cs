#pragma checksum "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e8c497fe077a76b5d9352cc895a51c4b876ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlyOnTickets_Index), @"mvc.1.0.view", @"/Views/FlyOnTickets/Index.cshtml")]
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
#line 1 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/_ViewImports.cshtml"
using pdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/_ViewImports.cshtml"
using pdemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e8c497fe077a76b5d9352cc895a51c4b876ce4", @"/Views/FlyOnTickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d2e212f616595bd5d7e956da60b59e0eee2174", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FlyOnTickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pdemo.Models.FlyOnTickets>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FlyOnTickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>


<style>

    .table {
        box-shadow: 3px 4px 0px 0px #1564ad;
        background: linear-gradient(to bottom, #f3f7fb 5%, #c0d9f2 100%);
        background-color: #e2eefa;
        border-radius: 5px;
        border: 1px solid #337bc4;
        display: inline-block;
        cursor: pointer;
        font-family: Arial;
        font-size: 17px;
        font-weight: bold;
        padding: 12px 44px;
        text-decoration: none;
        text-shadow: 0px 1px 0px #528ecc;
    }

        .table tr:hover {
            background: linear-gradient(to bottom, #c5e0fb 5%, #bddbfa 100%);
            background-color: #80b5ea;
        }

    button:active {
        position: relative;
        top: 1px;
    }

    .menu {
        display: flex;
        justify-content: space-between;
    }

    .menuBar {
        width: 100%
    }

    .menuBar1 {
        display: flex;
        justify-content: center;
        align-items: center;
        margin-left: 10%;");
            WriteLiteral(@"
        margin-right: 10%;
    }

        .menuBar1 li {
            font-size: 16px;
            width: 20%;
            text-align: center;
            color: darkgrey;
            background-color: #E4E4E4;
        }


            .menuBar1 li a {
                display: block;
                height: 55px;
                text-decoration: none;
                color: #2f3363;
                background-color: #E4E4E4;
                padding-top: 18px;
            }

        .menuBar1 a:link {
            text-decoration: none;
        }

    .menuBar li:hover {
        background-color: whitesmoke;
        height: 100%;
        width: 20%;
    }



    .menuBar2 {
        display: flex;
        justify-content: center;
        align-items: center;
        margin-right: 9%;
    }

    .todo {
        margin-top: 20px;
    }

    td {
        border-left: 20px;
    }
</style>
<div style=""margin:20px;"">

    <p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce47762", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce48925", async() => {
                WriteLiteral("\r\n        <p>\r\n            pwd: <input type=\"text\" name=\"SearchString\" />\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 117 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Point));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 120 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 123 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 126 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 129 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FlightID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 132 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TakeoffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 138 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 142 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Point));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 145 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 148 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 151 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 154 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FlightID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 157 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TakeoffTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce415370", async() => {
                WriteLiteral("Edit <i class=\"fas fa-tag\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
                                               WriteLiteral(item.BookingNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 163 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <div class=""menu"">
        <div class=""menuBar"">
            <ul class=""menuBar1"">
                <li name=""seatChange""><a href=""#"">change flight</a></li>
                <li name=""dateChange""><a href=""#"">change date</a></li>
                <li name=""ftChange""><a href=""#"">change seat</a></li>
            </ul>
        </div>
    </div>

    <div class=""todo"">
        <table>
            <tr>
                <td>MemberID:</td>
                <td>1</td>
            </tr>
            <tr>
                <td>FlightID:</td>
                <td>1</td>
            </tr>
            <tr>
                <td>Lastname:</td>
                <td>hyde</td>
            </tr>
            <tr>
                <td>Firstname:</td>
                <td>ch</td>
            </tr>
        </table>
        <div>
            <select style=""margin-top:20px;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce418743", async() => {
                WriteLiteral("Japan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce419703", async() => {
                WriteLiteral("HongKong");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce420666", async() => {
                WriteLiteral("Bankok");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce421627", async() => {
                WriteLiteral("Korean");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"changeDate\" style=\"display:none\">\r\n        <div class=\"personalInfo1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce422743", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8c497fe077a76b5d9352cc895a51c4b876ce423016", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 209 "/Users/hyde/Documents/GitHub/flyondemo/pdemo/Views/FlyOnTickets/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                <table class=""table table-hover"">
                    <tbody>
                        <tr>
                            <th scope=""row"">姓名 Member Name</th>
                            <td>
                                <span>
                                    123
                                </span>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">帳號 Account</th>
                            <td>11</td>
                        </tr>
                        <tr>
                            <th scope=""row"">地址 Address</th>
                            <td>
                                11
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">手機 Cellphone</th>
                            <td>
                                11
                            </td>
                        </tr>
    ");
                WriteLiteral(@"                    <tr>
                            <th scope=""row"">生日 Birthday</th>
                            <td>
                                11
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">累積積分 Point</th>
                            <td>
                                11
                            </td>
                        </tr>
                        <tr>
                            <th></th>
                            <!-- btn btn-secondary btn-md -->
                            <td>
                                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div id=""changeSeat"">

    </div>
</div>
<script>
            const ftChange = document.getElementsByName(""ftChange"");
            ftChange[0].onclick = function () {
                todo.style.display = ""none"";
                changeDate.style.display = ""none"";
                changeSeat.style.display = """";
            };

            const dateChange = document.getElementsByName(""dateChange"");
            const changeDate = document.querySelector("".changeDate"");
            dateChange[0].onclick = function () {
                todo.style.display = ""none"";
                changeDate.style.display = """";
                changeSeat.style.display = ""none"";
            };

            const seatChange = document.getElementsByName(""seatChange"");
            const todo = document.querySelector("".todo"");
            seatChange[0].onclick = function () {
                todo.style.display = """";
                changeDate.style.display = ""none"";
            };");
            WriteLiteral("\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pdemo.Models.FlyOnTickets>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
