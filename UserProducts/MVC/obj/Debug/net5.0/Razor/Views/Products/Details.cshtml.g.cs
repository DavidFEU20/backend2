#pragma checksum "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e13621bad8b7e0deed07242e10672891732d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e13621bad8b7e0deed07242e10672891732d6c", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Product Details</h1>

<div>
    <div class=""container my-5 py-5 z-depth-1"">


        <!--Section: Content-->
        <section class=""text-center"">

            <!-- Section heading -->
            <h3 class=""font-weight-bold mb-5"">Product Details</h3>

            <div class=""row"">

                <div class=""col-lg-6"">


                    <!--Slides-->
                    <div class=""carousel-inner text-center text-md-left"" role=""listbox"">
                        <div class=""carousel-item active"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 638, "\"", 685, 1);
#nullable restore
#line 27 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
WriteAttributeValue("", 644, Html.DisplayFor(model => model.ImageUrl), 644, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                 alt=""First slide"" class=""img-fluid"">
                        </div>
                    </div>
                    <!--/.Slides-->


                </div>

                <div class=""col-lg-5 text-center text-md-left"">

                    <h2 class=""h2-responsive text-center text-md-left product-name font-weight-bold dark-grey-text mb-1 ml-xl-0 ml-4"">
                        <strong> ");
#nullable restore
#line 39 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
                            Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\r\n                    </h2>\r\n                    <h3 class=\"h3-responsive text-center text-md-left mb-5 ml-xl-0 ml-4\">\r\n                        <span class=\"font-weight-bold\">\r\n                            <strong> ");
#nullable restore
#line 43 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
                                Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@":- </strong>
                        </span>
                    </h3>

                    <!--Accordion wrapper-->
                    <!-- Accordion card -->
                    <div class=""card"">

                        <!-- Card header -->
                        <div class=""card-header"" role=""tab"" id=""headingOne1"">

                            <h5 class=""mb-0"">
                                Description

                            </h5>

                        </div>

                        <!-- Card body -->
                        <div id=""collapseOne1"" class=""collapse show"" role=""tabpanel"" aria-labelledby=""headingOne1""
                             data-parent=""#accordionEx"">
                            <div class=""card-body"">
                                ");
#nullable restore
#line 65 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>



                    <!--/.Accordion wrapper-->
                    <!-- Add to Cart -->
                    <section class=""color"">
                        <div class=""mt-5"">

                            <div class=""row mt-3"">
                                <div class=""col-md-12 text-center text-md-left text-md-right"">
                                    <button class=""btn btn-primary"""">
                                        <i class=""fas fa-cart-plus mr-2"" aria-hidden=""true""></i> Add to cart
                                    </button>
                                </div>
                            </div>
                        </div>
                    </section>
                    <!-- /.Add to Cart -->

                </div>

            </div>

        </section>
        <!--Section: Content-->


    </div>
</div>


<div>
    <hr />
    <dl class=""row"">
       ");
            WriteLiteral(" <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\admin\Desktop\be\uppgifter\uppgift2\backend2\UserProducts\MVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            \r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591