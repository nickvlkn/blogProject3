#pragma checksum "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7ceade0a6db56db8fe6df6dbe01075f9959b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\_ViewImports.cshtml"
using blogProject3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\_ViewImports.cshtml"
using blogProject3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7ceade0a6db56db8fe6df6dbe01075f9959b5e", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dafa3e3c03adcbd8d1cb04689035033e8be4ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""row inner-sec"">
            <!--left-->
            <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
#nullable restore
#line 15 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <article class=""blog-grid-top"">

                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""single.html"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 739, "\"", 760, 1);
#nullable restore
#line 22 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
WriteAttributeValue("", 745, item.BlogImage, 745, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 779, "\"", 785, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> 
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0 Comments
                                        </a>
                                    </li>

                               ");
            WriteLiteral(@" </ul>
                            </div>
                        </div>

                        <h3>
                            <a href=""single.html"">Amet consectetur adipisicing </a>
                        </h3>
                        <p>
                            ");
#nullable restore
#line 51 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
                       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </article>
                    <article class=""blog-grid-top my-5"">
                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""single.html"">
                                    <img src=""images/b4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2567, "\"", 2573, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> FEB 15,2018
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 201 Likes
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 15 Comments
                                        </a>
                                    </li>

          ");
            WriteLiteral(@"                      </ul>
                            </div>
                        </div>

                        <h3>
                            <a href=""single.html"">Amet consectetur adipisicing </a>
                        </h3>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
                            aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
                            aute irudre dolor in elit sed uta labore dolore reprehender
                        </p>
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </article>
                    <article class=""blog-grid-top mb-4"">
                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""si");
            WriteLiteral("ngle.html\">\r\n                                    <img src=\"images/b1.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4713, "\"", 4719, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> FEB 15,2018
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 201 Likes
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 15 Comments
                                        </a>
                                    </li>

          ");
            WriteLiteral(@"                      </ul>
                            </div>
                        </div>

                        <h3>
                            <a href=""single.html"">Amet consectetur adipisicing </a>
                        </h3>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
                            aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
                            aute irudre dolor in elit sed uta labore dolore reprehender
                        </p>
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </article>
");
#nullable restore
#line 133 "C:\Users\yildi\Desktop\.netcore\blogProject3\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-left"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">1</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">2</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">3</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
               
 ");
            WriteLiteral(@"               </div>
            <!--//left-->
            <!--right-->
            <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-left"">
                <div class=""right-blog-info text-left"">
                    <div class=""tech-btm"">
                        <img src=""images/banner1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7922, "\"", 7928, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"tech-btm\">\r\n                        <h4>Sign up to our newsletter</h4>\r\n                        <p>Pellentesque dui, non felis. Maecenas male </p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7ceade0a6db56db8fe6df6dbe01075f9959b5e14057", async() => {
                WriteLiteral("\r\n                            <input type=\"email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 8264, "\"", 8275, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" value=\"Subscribe\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                    <div class=""tech-btm"">
                        <h4>Categories</h4>
                        <ul class=""list-group single"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                Cras justo odio
                                <span class=""badge badge-primary badge-pill"">14</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                Dapibus ac facilisis in
                                <span class=""badge badge-primary badge-pill"">2</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                Morbi leo risus
                                <span class=""badge badge-primary badge-pill"">1</span>
                            </li>
 ");
            WriteLiteral(@"                       </ul>
                    </div>
                    <div class=""tech-btm"">
                        <h4>Top stories of the week</h4>

                        <div class=""blog-grids row mb-3"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 9824, "\"", 9830, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Jan, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                        <div class=""blog-grids row mb-3"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/6.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 10769, "\"", 10775, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">
                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Feb, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""single-gd my-5 tech-btm"">
                        <h4>Our Progress</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
              ");
            WriteLiteral(@"                   aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""pro");
            WriteLiteral(@"gress"">
                            <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""single-gd tech-btm text-left"">
                        <h4>Recent Post</h4>
                        <div class=""blog-grids"">
                            <div class=""blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/b1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 13469, "\"", 13475, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                </h5>
                            </div>

                        </div>
                    </div>

                    <div class=""tech-btm widget_social text-left"">
                        <h4>Stay Connect</h4>
                        <ul>

                            <li>
                                <a class=""twitter"" href=""#"">
                                    <i class=""fab fa-twitter""></i>
                                    <span class=""count"">317K</span> Twitter Followers
                                </a>
                            </li>
                            <li>
                                <a class=""facebook"" href=""#"">
                                   ");
            WriteLiteral(@" <i class=""fab fa-facebook-f""></i>
                                    <span class=""count"">218k</span> Twitter Followers
                                </a>
                            </li>
                            <li>
                                <a class=""dribble"" href=""#"">
                                    <i class=""fab fa-dribbble""></i>

                                    <span class=""count"">215k</span> Dribble Followers
                                </a>
                            </li>
                            <li>
                                <a class=""pin"" href=""#"">
                                    <i class=""fab fa-pinterest""></i>
                                    <span class=""count"">190k</span> Pinterest Followers
                                </a>
                            </li>

                        </ul>
                    </div>
                    <div class=""tech-btm"">
                        <h4>Recent Posts</h4>

                       ");
            WriteLiteral(" <div class=\"blog-grids row mb-3 text-left\">\r\n                            <div class=\"col-md-5 blog-grid-left\">\r\n                                <a href=\"single.html\">\r\n                                    <img src=\"images/1.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 15770, "\"", 15776, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Jan, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                        <div class=""blog-grids row mb-3 text-left"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/5.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 16725, "\"", 16731, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Jan, 2018
                                    </span>
                                </div>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                        <div class=""blog-grids row mb-3 text-left"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 17737, "\"", 17743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">
                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Feb, 2018
                                    </span>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </aside>
            <!--//right-->
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591