#pragma checksum "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04515af6e2f263702c902ce2e8d662d3965a61d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\_ViewImports.cshtml"
using WebAppProftS2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\_ViewImports.cshtml"
using WebAppProftS2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04515af6e2f263702c902ce2e8d662d3965a61d", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16740b0ee179359c6c1aecb07f3d671e6a7b16a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ondblclick", new global::Microsoft.AspNetCore.Html.HtmlString("openCustomer(this.value)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
  
    Layout = Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d5165", async() => {
                WriteLiteral("\r\n    <title>title</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d6159", async() => {
                WriteLiteral("\r\n<screen style=\"display:flex;\">\r\n    <div style=\"left:0; position: relative; width: 70%\">\r\n        <div style=\"display: flex\">\r\n        <div style=\"left:0; position: relative; width: 20%\">\r\n            <label>Filters:</label>\r\n            <select");
                BeginWriteAttribute("onchange", " onchange=\"", 448, "\"", 487, 3);
#nullable restore
#line 22 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 459, Model.Dropdown, 459, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 474, "=", 475, 2, true);
                WriteAttributeValue(" ", 476, "this.value", 477, 11, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d7233", async() => {
#nullable restore
#line 23 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                    Write(Model.Dropdown = Dropdown.All);

#line default
#line hidden
#nullable disable
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d8444", async() => {
#nullable restore
#line 24 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                    Write(Model.Dropdown = Dropdown.Premium);

#line default
#line hidden
#nullable disable
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d9659", async() => {
#nullable restore
#line 25 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                    Write(Model.Dropdown = Dropdown.Free);

#line default
#line hidden
#nullable disable
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d10871", async() => {
#nullable restore
#line 26 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                    Write(Model.Dropdown = Dropdown.Prospects);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n            <div style=\"position: relative; width: 80%\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d12194", async() => {
                    WriteLiteral("\r\n                    <input type=\"text\" value=\"searchbar\" style=\"width: 80%\">\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n              </div>\r\n        <select name=\"credit_card\" style=\"height: 70vh; width: 90%;\" size=\"100\" onchange=\"showCustomerDetails(this.value)\">\r\n");
#nullable restore
#line 36 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
              
                // //todo implement in blazor
                // switch (Model.Dropdown)
                // {    
                //     case Dropdown.All:
                string jsonString;
                        foreach (var customer in Model.PremiumCustomers)
                        {
                            {
                                jsonString = "{\"name\":\"" + @customer.Name + "\",\"phone\":\"" + customer.PhoneNr + "\", \"email\":\"" + customer.Email + "\",\"id\":\"" + customer.Id + "\"}";
                            }
                            //todo fix sizing in blazor

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d14630", async() => {
                    WriteLiteral("\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 49 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 50 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 51 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.PhoneNr);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                               WriteLiteral(jsonString);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                        }
                        foreach (var customer in Model.FreeCustomers)
                        {
                            {
                                jsonString = "{\"name\":\"" + @customer.Name + "\",\"phone\":\"" + customer.PhoneNr + "\", \"email\":\"" + customer.Email + "\",\"id\":\"" + customer.Id + "\"}";
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d18188", async() => {
                    WriteLiteral("\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 60 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 61 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 62 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.PhoneNr);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                               WriteLiteral(jsonString);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                        }
                        foreach (var customer in Model.Prospects)
                        {
                            {
                                jsonString = "{\"name\":\"" + @customer.Name + "\",\"phone\":\"" + customer.PhoneNr + "\", \"email\":\"" + customer.Email + "\",\"id\":\"" + customer.Id + "\"}";
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04515af6e2f263702c902ce2e8d662d3965a61d21742", async() => {
                    WriteLiteral("\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 71 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 72 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                <div style=\"width: 33%\">");
#nullable restore
#line 73 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                                                   Write(customer.PhoneNr);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                               WriteLiteral(jsonString);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\Tom\Desktop\WebAppKR\WebApplicationFontys\WebApp\Views\Home\Dashboard.cshtml"
                        }
                    //     break;
                    // case Dropdown.Premium:
                    //     foreach (var customer in Model.PremiumCustomers)
                    //     {
                    //         <option value="@customer">
                    //             <collumn>@customer.Name</collumn>
                    //             <collumn>@customer.Email</collumn>
                    //             <collumn>@customer.PhoneNr</collumn>
                    //         </option>
                    //     }
                    //     break;
                    // case Dropdown.Free:
                    //     foreach (var customer in Model.FreeCustomers)
                    //     {
                    //         <option value="@customer">
                    //             <collumn>@customer.Name</collumn>
                    //             <collumn>@customer.Email</collumn>
                    //             <collumn>@customer.PhoneNr</collumn>
                    //         </option>
                    //     }
                    //     break;
                    // case Dropdown.Prospects:
                    //     foreach (var prospect in Model.Prospects)
                    //     {
                    //         <option value="@prospect">
                    //             <collumn>@prospect.Name</collumn>
                    //             <collumn>@prospect.Email</collumn>
                    //             <collumn>@prospect.PhoneNr</collumn>
                    //         </option>
                    //     }
                    //     break;
                //}
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n          \r\n    </div>\r\n    <div style=\"right:0; position: relative; width: 30%\">\r\n        <p id=\"customerdetails\" style=\"white-space: pre-line\">\r\n        </p>\r\n    </div>\r\n</screen>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
