#pragma checksum "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98d98eb18b7201152d2d570da9bad1e006999a60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Add), @"mvc.1.0.view", @"/Views/Admin/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d98eb18b7201152d2d570da9bad1e006999a60", @"/Views/Admin/Add.cshtml")]
    public class Views_Admin_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
  
    List<MovieApp.Service.Models.Category> categories = ViewBag.Categories;
    List<MovieApp.Service.Models.Director> directors = ViewBag.Directors;
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<form action=\"/Admin/Add\" method=\"post\" enctype=\"multipart/form-data\">\r\n    <br />\r\n    MovieWriter:<input type=\"text\" name=\"MovieWriter\" id=\"MovieWriter\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 478, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    Category:\r\n    <select name=\"CategoryId\" class=\"form-control\">\r\n");
#nullable restore
#line 15 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
         foreach (var item in categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 645, "\"", 661, 1);
#nullable restore
#line 17 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
WriteAttributeValue("", 653, item.Id, 653, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 18 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n    <br />\r\n    MovieDirector:<select name=\"DiretorId\" class=\"form-control\">\r\n");
#nullable restore
#line 22 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
         foreach (var item in directors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 868, "\"", 884, 1);
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
WriteAttributeValue("", 876, item.Id, 876, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Add.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    <br />
    MovieImage:<input class=""form-control"" type=""file"" id=""image"" name=""image""><br>
    <br />
    MovieVideo:  <input class=""form-control"" type=""file"" id=""video"" name=""video"" multiple>
    <br />
    MovieTime:<input type=""text"" name=""MovieTime"" id=""MovieTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1231, "\"", 1239, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieYear:<input type=\"text\" name=\"MovieYear\" id=\"MovieYear\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1342, "\"", 1350, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <br />\r\n    MovieTitle:<input type=\"text\" name=\"MovieTitle\" id=\"MovieTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1458, "\"", 1466, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieDescription:<textarea name=\"MovieDescription\" id=\"MovieDescription\" class=\"form-control\" rows=\"3\"");
            BeginWriteAttribute("value", " value=\"", 1590, "\"", 1598, 0);
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n    <br />\r\n\r\n\r\n    <button type=\"submit\" value=\"Update\" class=\"btn btn-info\">Movie Add</button>\r\n\r\n</form>\r\n");
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
