#pragma checksum "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6e64bd0033d0b8360ecf4eacf48997507239db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetIndex), @"mvc.1.0.view", @"/Views/Home/GetIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6e64bd0033d0b8360ecf4eacf48997507239db", @"/Views/Home/GetIndex.cshtml")]
    public class Views_Home_GetIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Service.Models.Movy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
  
    ViewData["Title"] = "GetIndex";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""hero "" style=""background: url('../../images/add.jpg'); "">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12""></div>
        </div>
    </div>
</div>
<div style=""margin-top:400px;""></div>
<div class=""page-single movie-single movie_single "">

    <div class=""container"">
        <div class=""row ipad-width2"">
            <div class=""col-md-4 col-sm-12 col-xs-12"">
                <div class=""movie-img sticky-sb"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 769, 1);
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 752, Model.MovieVideo, 752, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 775, "\"", 798, 1);
#nullable restore
#line 24 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 781, Model.MovieImage, 781, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a> \r\n                    <div class=\"movie-btn\">\r\n                        <div class=\"btn-transform transform-vertical red\">\r\n                            <div><a");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 987, 1);
#nullable restore
#line 27 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 970, Model.MovieVideo, 970, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item item-1 redbtn\"> <i class=\"ion-play\"></i> Watch Movie</a></div>\r\n                            <div><a");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1124, 1);
#nullable restore
#line 28 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 1107, Model.MovieVideo, 1107, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""item item-2 redbtn fancybox-media hvr-grow""><i class=""ion-play""></i></a></div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-md-8 col-sm-12 col-xs-12"">
                <div class=""movie-single-ct main-content"">
                    <h1 class=""bd-hd"">");
#nullable restore
#line 36 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                 Write(Model.MovieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("   <span>");
#nullable restore
#line 36 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                           Write(Model.MovieYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h1>

                    <div class=""movie-tabs"">
                        <div class=""tabs"">
                            <ul class=""tab-links tabs-mv"">
                                <li class=""active""><a href=""#overview"">Overview</a></li>
                                <li><a href=""#reviews""> Reviews</a></li>

                            </ul>
                            <div class=""tab-content"">
                                <div id=""overview"" class=""tab active"">
                                    <div class=""row"">
                                        <div class=""col-md-8 col-sm-12 col-xs-12"">
                                            <p> ");
#nullable restore
#line 49 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                           Write(Model.MovieDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>

                                        <br />
                                        <div class=""col-md-4 col-xs-12 col-sm-12"">
                                            <div class=""sb-it"">
                                                <h6>Director: </h6>
");
#nullable restore
#line 56 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                 foreach (var item in Model.Directors)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                   <p><a");
            BeginWriteAttribute("href", " href=\"", 2736, "\"", 2769, 2);
            WriteAttributeValue("", 2743, "/Home/GetDirector/", 2743, 18, true);
#nullable restore
#line 58 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 2761, item.Id, 2761, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 58 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                                  Write(item.Movies.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a> </p> \r\n");
#nullable restore
#line 59 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                
                                            </div>
                                            <div class=""sb-it"">
                                                <h6>Writer: </h6>
                                                <p><a href=""#"">");
#nullable restore
#line 64 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                          Write(Model.MovieWriter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                            </div>\r\n                                            <div class=\"sb-it\">\r\n                                                <h6>Stars: </h6>\r\n");
#nullable restore
#line 68 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                 foreach (var item in Model.Actors)

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                                                              
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 3611, "\"", 3641, 2);
            WriteAttributeValue("", 3618, "/Home/GetActor/", 3618, 15, true);
#nullable restore
#line 70 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 3633, item.Id, 3633, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 70 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                                Write(item.Movies.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a> </p> ");
#nullable restore
#line 70 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                                                                                                                              
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"sb-it\">\r\n                                                <h6>Release Date:</h6>\r\n                                                <p>");
#nullable restore
#line 77 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                              Write(Model.MovieYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                            <div class=\"sb-it\">\r\n                                                <h6>Run Time:</h6>\r\n                                                <p>");
#nullable restore
#line 81 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                              Write(Model.MovieTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <video controls=""controls"">
                                <source");
            BeginWriteAttribute("src", " src=\"", 4605, "\"", 4628, 1);
#nullable restore
#line 88 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 4611, Model.MovieVideo, 4611, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\"  />\r\n                            </video>\r\n");
            WriteLiteral(@"
                            <div id=""reviews"" class=""tab review"">
                                <div class=""row"">
                                    <div class=""rv-hd"">
                                        <ul class=""tab-links tabs-mv"" style=""margin-left:20px;"">
                                            <li class=""active""><a");
            BeginWriteAttribute("href", " href=\"", 5360, "\"", 5391, 2);
            WriteAttributeValue("", 5367, "/Home/GetIndex/", 5367, 15, true);
#nullable restore
#line 101 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 5382, Model.Id, 5382, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Overview</a></li>\r\n                                            <li><a href=\"#reviews\"> Reviews</a></li>\r\n                                        </ul>\r\n                                    </div>\r\n\r\n");
#nullable restore
#line 106 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                     using (Html.BeginForm("Ekle", "Home", FormMethod.Post))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input type=\"text\" name=\"MovieId\" id=\"MovieId\"");
            BeginWriteAttribute("value", " value=\"", 5810, "\"", 5827, 1);
#nullable restore
#line 108 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
WriteAttributeValue("", 5818, Model.Id, 5818, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none; margin-left:15px;\" />\r\n");
            WriteLiteral(@"                                        <input type=""text"" class=""form-control"" name=""GuestName"" id=""GuestName"" placeholder=""Kullanıcı Adı"" style="" margin-left: 15px; width: 550px; border-radius: 90px; background: #000; "" />
                                        <br />
                                        <input type=""text"" class=""form-control"" name=""GuestMail"" id=""GuestMail"" placeholder=""Kullanıcı Mail"" style="" margin-left: 15px; width: 550px; border-radius: 90px; background: #000;"" />
                                        <br />
                                        <input type=""text"" class=""form-control"" name=""commentTitle"" id=""commentTitle"" placeholder=""Başlık Giriniz"" style="" margin-left: 15px; width: 550px; border-radius: 90px; background: #000;"" />
                                        <br />
                                        <input type=""text"" class=""form-control"" name=""comment1"" id=""comment1"" placeholder=""Yorumunuz"" style="" margin-left: 15px; width: 550px; height: 50px; border-");
            WriteLiteral("radius: 90px; background: #000;\" />\r\n");
            WriteLiteral("                                        <br />\r\n                                        <button class=\"btn btn-info btn-danger\" type=\"submit\" style=\" margin-left: 15px; border-radius: 10px;\"><b>Yeni Yorum Ekle</b></button>\r\n");
#nullable restore
#line 120 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                     foreach (var item in Model.comments)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"mv-user-review-item\" style=\"margin-left:15px;\">\r\n                                            <div class=\"user-infor\">\r\n                                                <img src=\"/images/users.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7564, "\"", 7570, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div>\r\n                                                    <h3>");
#nullable restore
#line 128 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                   Write(item.commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                                    <p class=\"time\">\r\n                                                        ");
#nullable restore
#line 131 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                                   Write(item.commentTime.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n\r\n                                                </div>\r\n                                            </div>\r\n                                            <p>");
#nullable restore
#line 136 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                          Write(item.comment1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        </div>\r\n");
#nullable restore
#line 138 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\GetIndex.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- end of footer section-->\r\n\r\n\r\n");
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
