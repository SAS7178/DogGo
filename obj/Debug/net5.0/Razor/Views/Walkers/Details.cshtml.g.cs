#pragma checksum "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1c866c0515337d57d1b124b15dddca20d7e744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
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
#line 1 "C:\Users\steph\workspace\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\steph\workspace\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1c866c0515337d57d1b124b15dddca20d7e744", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.WalkerViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 class=\"mb-4\">Walker Profile</h1>\r\n\r\n    <section class=\"container\">\r\n        <img style=\"width:100px;float:left;margin-right:20px\"");
            BeginWriteAttribute("src", "\r\n             src=\"", 244, "\"", 286, 1);
#nullable restore
#line 13 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 264, Model.Walker.ImageUrl, 264, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div>\r\n            <label class=\"font-weight-bold\">Name:</label>\r\n            <span>");
#nullable restore
#line 16 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
             Write(Model.Walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n   \r\n        <div>\r\n            <label class=\"font-weight-bold\">Neighborhood:</label>\r\n            <span>");
#nullable restore
#line 21 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
             Write(Model.Walker.Neighborhood.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
      
 
    </section>

    <hr class=""mt-5"" />
    <div class=""clearfix""></div>

    <div class=""row"">
        <section class=""col-8 container mt-5"">
            <h1 class=""text-left"">Recent Walks</h1>

            <div class=""row"">
");
#nullable restore
#line 35 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                foreach (Walks walk in @Model.Walker.Walks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card m-4"" style=""width: 18rem;"">
                        <div class=""card-body"">
                            <div>
                                <label class=""font-weight-bold"">Date:</label>
                                <span>");
#nullable restore
#line 41 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                 Write(walk.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Client:</label>\r\n                                <span>");
#nullable restore
#line 45 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                 Write(walk.Dog.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Neighborhood:</label>\r\n                                <span>");
#nullable restore
#line 49 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                 Write(walk.Dog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Duration:</label>\r\n                                <span>");
#nullable restore
#line 53 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                 Write(walk.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            \r\n        </section>\r\n\r\n        <section class=\"col-lg-4 col-md-8 container mt-5\">\r\n            <h1>Total Walk Time:</h1> <div>");
#nullable restore
#line 63 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                      Write(Model.Walker.TotalDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n           \r\n    </section>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 70 "C:\Users\steph\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {  id = Model.Walks  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1c866c0515337d57d1b124b15dddca20d7e7448309", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.WalkerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
