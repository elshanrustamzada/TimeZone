#pragma checksum "C:\Users\elsha\OneDrive\Desktop\Backend\TimeZone\TimeZone\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3c6cb61b6a0f0e63ef3aa960162be81a84a901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\elsha\OneDrive\Desktop\Backend\TimeZone\TimeZone\Views\_ViewImports.cshtml"
using TimeZone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elsha\OneDrive\Desktop\Backend\TimeZone\TimeZone\Views\_ViewImports.cshtml"
using TimeZone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3c6cb61b6a0f0e63ef3aa960162be81a84a901", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1d985ae7925330f179674fe03687c3ced7f2a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\elsha\OneDrive\Desktop\Backend\TimeZone\TimeZone\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main>
    <!-- Hero Area Start-->
    <div class=""slider-area "">
        <div class=""single-slider slider-height2 d-flex align-items-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <div class=""hero-cap text-center"">
                            <h2>Watch Shop</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Hero Area End-->
    <!-- Latest Products Start -->
    <section class=""popular-items latest-padding"">
        <div class=""container"">
            <div class=""row product-btn justify-content-between mb-40"">
                <div class=""properties__button"">
                    <!--Nav Button  -->
                    <nav>
                        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                            <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""t");
            WriteLiteral(@"ab"" href=""#nav-home"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">NewestArrivals</a>
                            <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false""> Price high to low</a>
                            <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab"" aria-controls=""nav-contact"" aria-selected=""false""> Most populer </a>
                        </div>
                    </nav>
                    <!--End Nav Button  -->
                </div>
                <!-- Grid and List view -->
                <div class=""grid-list-view"">
                </div>
                <!-- Select items -->
                <div class=""select-this"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c6cb61b6a0f0e63ef3aa960162be81a84a9016230", async() => {
                WriteLiteral("\r\n                        <div class=\"select-itms\">\r\n                            <select name=\"select\" id=\"select1\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c6cb61b6a0f0e63ef3aa960162be81a84a9016646", async() => {
                    WriteLiteral("40 per page");
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c6cb61b6a0f0e63ef3aa960162be81a84a9017906", async() => {
                    WriteLiteral("50 per page");
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c6cb61b6a0f0e63ef3aa960162be81a84a9019166", async() => {
                    WriteLiteral("60 per page");
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c6cb61b6a0f0e63ef3aa960162be81a84a90110426", async() => {
                    WriteLiteral("70 per page");
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
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            <!-- Nav Card -->
            <div class=""tab-content"" id=""nav-tabContent"">
                <!-- card one -->
                <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                    <div class=""row"">
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3047, "\"", 3053, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular2.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 4082, "\"", 4088, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular3.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 5117, "\"", 5123, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular4.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 6152, "\"", 6158, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular5.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 7187, "\"", 7193, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular6.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 8222, "\"", 8228, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Card two -->
                <div class=""tab-pane fade"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
                    <div class=""row"">
                        <div class=""col-xl-4 col-lg-");
            WriteLiteral("4 col-md-6 col-sm-6\">\r\n                            <div class=\"single-popular-items mb-50 text-center\">\r\n                                <div class=\"popular-img\">\r\n                                    <img src=\"assets/img/gallery/popular1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 9495, "\"", 9501, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular2.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 10530, "\"", 10536, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular3.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 11565, "\"", 11571, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular4.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 12600, "\"", 12606, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular5.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 13635, "\"", 13641, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular6.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 14670, "\"", 14676, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Card three -->
                <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">
                    <div class=""row"">
                        <div class=""col-xl-4 col-l");
            WriteLiteral("g-4 col-md-6 col-sm-6\">\r\n                            <div class=\"single-popular-items mb-50 text-center\">\r\n                                <div class=\"popular-img\">\r\n                                    <img src=\"assets/img/gallery/popular1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 15945, "\"", 15951, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular2.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 16980, "\"", 16986, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular3.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 18015, "\"", 18021, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular4.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 19050, "\"", 19056, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular5.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 20085, "\"", 20091, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-6"">
                            <div class=""single-popular-items mb-50 text-center"">
                                <div class=""popular-img"">
                                    <img src=""assets/img/gallery/popular6.");
            WriteLiteral("png\"");
            BeginWriteAttribute("alt", " alt=\"", 21120, "\"", 21126, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""img-cap"">
                                        <span>Add to cart</span>
                                    </div>
                                    <div class=""favorit-items"">
                                        <span class=""flaticon-heart""></span>
                                    </div>
                                </div>
                                <div class=""popular-caption"">
                                    <h3><a href=""product_details.html"">Thermo Ball Etip Gloves</a></h3>
                                    <span>$ 45,743</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Nav Card -->
        </div>
    </section>
    <!-- Latest Products End -->
    <!--? Shop Method Start-->
    <div class=""shop-method-area"">
        <div class=""container"">
            <div");
            WriteLiteral(@" class=""method-wrapper"">
                <div class=""row d-flex justify-content-between"">
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i class=""ti-package""></i>
                            <h6>Free Shipping Method</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i class=""ti-unlock""></i>
                            <h6>Secure Payment System</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i ");
            WriteLiteral(@"class=""ti-reload""></i>
                            <h6>Secure Payment System</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Shop Method End-->
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591