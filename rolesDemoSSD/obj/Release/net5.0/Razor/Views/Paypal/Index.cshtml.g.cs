#pragma checksum "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c869bb6abbe7935465dcace8a9577d2ea0b79f2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paypal_Index), @"mvc.1.0.view", @"/Views/Paypal/Index.cshtml")]
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
#line 1 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c869bb6abbe7935465dcace8a9577d2ea0b79f2c", @"/Views/Paypal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076307135dc47d879fc427f06362ff74e4928b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Paypal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<rolesDemoSSD.Data.IPN>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c869bb6abbe7935465dcace8a9577d2ea0b79f2c4623", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.custom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.create_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerMiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.payerStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.paymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.paymentState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.custom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.create_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerMiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.payerStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.paymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.paymentState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c869bb6abbe7935465dcace8a9577d2ea0b79f2c16462", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
                                           WriteLiteral(item.paymentID);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c869bb6abbe7935465dcace8a9577d2ea0b79f2c18657", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
                                              WriteLiteral(item.paymentID);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c869bb6abbe7935465dcace8a9577d2ea0b79f2c20858", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
                                             WriteLiteral(item.paymentID);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 118 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""paypal-button""></div>
<script src=""https://www.paypalobjects.com/api/checkout.js""></script>
<script>
    paypal.Button.render({
        env: 'sandbox', // Or ' production '
        style: { // You can customize your button here.
            size: 'small',
            color: 'gold',
            shape: 'pill',
            label: 'checkout'
        },
        client: {
            // You need to change this to your client ID
            sandbox: 'AdWdXFWXAFyPZsxcT9hkF37fdvfsfa9CPfU8PjqlLB52v9b0Cx3WpgClj15u8NtxK4kVQPJhXOnmb70Y',
            // production: '3W8F5EEJKUJP4KSY'  // Switch to ‘production’ when live.
        },

        commit: true, // Show a 'Pay Now' button

        payment: function (data, actions) {
            return actions.payment.create({
                payment: {
                    transactions: [{
                        // The 'custom' field helps you to link the paypal request
                        // with paypal's response whi");
            WriteLiteral(@"ch is important.

                        // You may want use a 'custom' field to send an accountID from
                        // your site so you can uniquely identify the person making the
                        // payment when Paypal notifies you.

                        // Sometimes a person at your site will pay at Paypal with
                        // an entirely different set of credentials. They may pay with
                        // a credit card or account which belongs to their spouse or
                        // another family member. In situations like these, relating
                        // payments to accounts on your site can be difficult.

                        // The custom property value that you send to Paypal for a
                        // payment request is returned in Paypal's reponse.
                        custom: 'Custom data goes here!',
                        amount: { total: ");
#nullable restore
#line 161 "C:\Users\stell\OneDrive\Desktop\rewindlatest\RewindV2\rolesDemoSSD\Views\Paypal\Index.cshtml"
                                    Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", currency: 'USD' }
                    }
                    ]
                }
            });
        },

        onAuthorize: function (data, actions) {
            return actions.payment.execute().then(function (payment) {
                console.log(""This is what comes back from Paypal: "")
                console.log(payment);
                alert(""This JSON is from Paypal: "" + JSON.stringify(payment));
                console.log(""-------------------------------------"")
                var dataObject = {
                    ""cart"":             payment.cart,
                    ""intent"":           payment.intent,
                    ""paymentID"":        payment.id,
                    ""create_time"":      payment.create_time,
                    ""paymentState"":     payment.state,
                    ""payerEmail"":       payment.payer.payer_info.email,
                    ""payerID"":          payment.payer.payer_info.payer_id,
                    ""payerFirstName"":   payment.payer.payer");
            WriteLiteral(@"_info.first_name,
                    ""payerLastName"":    payment.payer.payer_info.last_name,
                    ""payerMiddleName"":  payment.payer.payer_info.middle_name,
                    ""payerCountryCode"": payment.payer.payer_info.country_code,
                    ""paymentMethod"":    payment.payer.payment_method,
                    ""payerStatus"":      payment.payer.status,
                    ""amount"":           payment.transactions[0].amount.total,
                    ""currency"":         payment.transactions[0].amount.currency,
                    ""custom"":           payment.transactions[0].custom
                }

                // The payment is complete!
                // You can now show a confirmation message to the customer
                $.ajax({
                    type: ""post"",
                    url: ""/Paypal/PaySuccess"",
                    data: JSON.stringify(dataObject),
                    contentType: ""application/json; charset=utf-8"",
                    dataTyp");
            WriteLiteral(@"e: ""json"",

                    //after success
                    success: function (msg) {
                        console.log(""Data: "" + JSON.stringify(data));
                        window.location.href
                        =""/Paypal/FinishShopping?paymentID="" + data.paymentID;
                    },
                    //after fail
                    error: function (msg) {
                        alert(""fail: "" + JSON.stringify(msg));
                    }
                });
            })
        },

        onCancel: function (data, actions) {
            /*
            * Buyer cancelled the payment
            */
        },
    }, '#paypal-button');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<rolesDemoSSD.Data.IPN>> Html { get; private set; }
    }
}
#pragma warning restore 1591
