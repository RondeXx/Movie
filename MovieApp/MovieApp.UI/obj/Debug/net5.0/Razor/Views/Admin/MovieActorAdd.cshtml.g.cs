#pragma checksum "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae511555f7152e7036a6e0d69731677ba35f26dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MovieActorAdd), @"mvc.1.0.view", @"/Views/Admin/MovieActorAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae511555f7152e7036a6e0d69731677ba35f26dd", @"/Views/Admin/MovieActorAdd.cshtml")]
    public class Views_Admin_MovieActorAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Service.Models.Movy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
  
    ViewData["Title"] = "MovieActorAdd";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<form action=\"/Admin/MovieActorAdd\" method=\"post\">\r\n    ");
#nullable restore
#line 9 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-control\">\r\n\r\n        <b> <p>Movie Name: ");
#nullable restore
#line 12 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
                      Write(Model.MovieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n        <b>Movie İmage:<img");
            BeginWriteAttribute("src", " src=\"", 337, "\"", 360, 1);
#nullable restore
#line 13 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
WriteAttributeValue("", 343, Model.MovieImage, 343, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 361, "\"", 384, 1);
#nullable restore
#line 13 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
WriteAttributeValue("", 367, Model.MovieTitle, 367, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"75\" height=\"75\" /></b>\r\n        <br />\r\n");
#nullable restore
#line 15 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
         foreach (var item in Model.Actors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><b>");
#nullable restore
#line 17 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 18 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"form-control\">\r\n        <select name=\"ActorsId\" class=\"form-control\">\r\n");
#nullable restore
#line 22 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
             foreach (var item in ViewBag.List)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option");
            BeginWriteAttribute("value", " value=\"", 723, "\"", 739, 1);
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
WriteAttributeValue("", 731, item.Id, 731, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\MovieActorAdd.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </select>\r\n\r\n\r\n    </div>\r\n    <button type=\"submit\" value=\"ActorsAdd\" class=\"btn btn-info\">Actors Add</button>  \r\n\r\n\r\n</form>\r\n<br /> \r\n<br /> \r\n<a href=\"/Admin/List/\" class=\"btn btn-danger\">Back List</a>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieApp.Service.Models.Movy> Html { get; private set; }
    }
}
#pragma warning restore 1591
