#pragma checksum "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31d6556dbbd49a9afd87d3ab81aa02226ba4df3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Restaurant), @"mvc.1.0.view", @"/Views/Restaurants/Restaurant.cshtml")]
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
#line 1 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\_ViewImports.cshtml"
using RestaurantReviewer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\_ViewImports.cshtml"
using RestaurantReviewer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31d6556dbbd49a9afd87d3ab81aa02226ba4df3", @"/Views/Restaurants/Restaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc619f5fbc2372cdd3e64b17eefaa6654f7f5a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_Restaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantReviewer.ViewModels.RestaurantViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/restaurantinfostyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToFavoriteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FavoriteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReviewList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df36945", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df37619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df38843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df310734", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n            <div class=\"carousel-item active\">\r\n                <img class=\"d-block w-100\"");
                BeginWriteAttribute("src", " src=\"", 1044, "\"", 1071, 1);
#nullable restore
#line 26 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 1050, Model.CarouselImage1, 1050, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"First slide\" height=\"450px\">\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\"");
                BeginWriteAttribute("src", " src=\"", 1211, "\"", 1238, 1);
#nullable restore
#line 29 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 1217, Model.CarouselImage2, 1217, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Second slide\" height=\"450px\">\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\"");
                BeginWriteAttribute("src", " src=\"", 1379, "\"", 1406, 1);
#nullable restore
#line 32 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 1385, Model.CarouselImage3, 1385, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""Third slide"" height=""450px"">
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    <div class=""container container-fluid info"">

        <h1>
            ");
#nullable restore
#line 48 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df313752", async() => {
                    WriteLiteral(@"
                <svg class=""bi bi-heart"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""black"" xmlns=""http://www.w3.org/2000/svg"">
                    <path fill-rule=""evenodd"" d=""M8 2.748l-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 01.176-.17C12.72-3.042 23.333 4.867 8 15z"" clip-rule=""evenodd"" />
                </svg>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-restaurantId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                                                                                                              WriteLiteral(Model.RestaurantId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-restaurantId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </h1>\r\n\r\n        <p>");
#nullable restore
#line 57 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
      Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 58 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
      Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p><a");
                BeginWriteAttribute("href", " href=\"", 3014, "\"", 3061, 1);
#nullable restore
#line 59 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 3021, Html.DisplayFor(model => model.Website), 3021, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Website</a></p>\r\n        <p>");
#nullable restore
#line 60 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
      Write(Html.DisplayFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <div>\r\n            <p>\r\n                ");
#nullable restore
#line 63 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
           Write(Html.DisplayFor(model => model.Hours));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </p>
        </div>
    </div>

    <div class=""container container-fluid info"">
        <div class=""row bootstrap snippets"">
            <div class=""col-xl-12"">
                <div class=""comment-wrapper"">
                    <div class=""panel panel-info"">
                        <div class=""panel-heading"">
                            <h3>
");
                WriteLiteral("                                <h4>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d6556dbbd49a9afd87d3ab81aa02226ba4df319327", async() => {
                    WriteLiteral("See Reviews\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                         WriteLiteral(Model.RestaurantId);

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
                WriteLiteral("\r\n                                    \r\n                                </h4>\r\n                                \r\n");
                WriteLiteral("                            </h3>\r\n\r\n\r\n                        </div>\r\n                        <div class=\"panel-body\">\r\n");
#nullable restore
#line 90 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                             if (@HttpContextAccessor.HttpContext.Session.GetString("username") == null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 4403, "\"", 4438, 1);
#nullable restore
#line 92 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 4410, Url.Action("Login", "User"), 4410, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Login to post your review</a>\r\n");
#nullable restore
#line 93 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                 using (Html.BeginForm("SendReview", "Restaurants", FormMethod.Post))
                                {
                                    for(int i = 1; i <= 5; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"radio\" id=\"rank\" name=\"rank\"");
                BeginWriteAttribute("value", " value=\"", 4890, "\"", 4900, 1);
#nullable restore
#line 100 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
WriteAttributeValue("", 4898, i, 4898, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 100 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                                                                          Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                                                                                 
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div id=\"rateyo\"></div>\r\n");
#nullable restore
#line 103 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                               Write(Html.TextAreaFor(model => model.ReviewDescription, new { cols = 350, rows = 5 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>&nbsp;</td>\r\n                                    <input type=\"submit\" value=\"Send\" />\r\n");
#nullable restore
#line 106 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                               Write(Html.HiddenFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                                                                
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\RestaurantReviewer - the good one - Copy (2)\RestaurantReviewer\Views\Restaurants\Restaurant.cshtml"
                                 
                               
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantReviewer.ViewModels.RestaurantViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
