#pragma checksum "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dafdd01b2f21401a79cd93a09d97ed8ced9b8fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Edit), @"mvc.1.0.view", @"/Views/Admin/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafdd01b2f21401a79cd93a09d97ed8ced9b8fec", @"/Views/Admin/Edit.cshtml")]
    public class Views_Admin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Service.Models.Movy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form action=\"/Admin/Edit\" method=\"post\">\r\n    ");
#nullable restore
#line 8 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Id:<input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 248, "\"", 265, 1);
#nullable restore
#line 9 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 256, Model.Id, 256, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n    <br />\r\n    MovieWriter:<input type=\"text\" name=\"MovieWriter\" id=\"MovieWriter\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 383, "\"", 409, 1);
#nullable restore
#line 11 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 391, Model.MovieWriter, 391, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieDirector:<input type=\"text\" name=\"MovieDirector\" id=\"MovieDirector\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 524, "\"", 552, 1);
#nullable restore
#line 13 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 532, Model.MovieDirector, 532, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieImage:<input type=\"file\" name=\"image\" id=\"image\" />\r\n    <br />\r\n    MovieVideo:<input type=\"file\" name=\"video\" id=\"video\" />\r\n    <br />\r\n    MovieTime:<input type=\"text\" name=\"MovieTime\" id=\"MovieTime\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 803, "\"", 827, 1);
#nullable restore
#line 19 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 811, Model.MovieTime, 811, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieYear:<input type=\"text\" name=\"MovieYear\" id=\"MovieYear\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 930, "\"", 954, 1);
#nullable restore
#line 21 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 938, Model.MovieYear, 938, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieTitle:<input type=\"text\" name=\"MovieTitle\" id=\"MovieTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1060, "\"", 1085, 1);
#nullable restore
#line 23 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1068, Model.MovieTitle, 1068, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n    MovieDescription:<textarea name=\"MovieDescription\" id=\"MovieDescription\" class=\"form-control\" rows=\"3\"");
            BeginWriteAttribute("value", " value=\"", 1209, "\"", 1217, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Admin\Edit.cshtml"
                                                                                                               Write(Model.MovieDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n    <br />\r\n\r\n\r\n    <button type=\"submit\" value=\"Update\" class=\"btn btn-info\">Update</button>\r\n\r\n</form> \r\n ");
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
