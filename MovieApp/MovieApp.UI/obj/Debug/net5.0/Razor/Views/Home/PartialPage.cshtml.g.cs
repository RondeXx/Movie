#pragma checksum "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\PartialPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d433cb795bfd76b338b62b4d194ee5c5ac90ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialPage), @"mvc.1.0.view", @"/Views/Home/PartialPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d433cb795bfd76b338b62b4d194ee5c5ac90ee", @"/Views/Home/PartialPage.cshtml")]
    public class Views_Home_PartialPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\PartialPage.cshtml"
 using (Html.BeginForm("PartialPage", "Home", FormMethod.Get))
//formumuz bir etkileşime giriyor post mu get mi olunca yapıcak nerde gelicek bilgiler bunları belirliyoruz deger döndürdügümüz için şart
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"top-search\">\r\n");
            WriteLiteral(@"        <input type=""text"" name=""p"" placeholder=""Search for a movie, TV Show or celebrity that you are looking for"">

        <button type=""submit"" style=""background-color: #2d4862; color: #fff; width: 80px;height:46px;""><b>Film Ara</b></button>
    </div>
");
#nullable restore
#line 15 "C:\Users\Vakıf Global\source\repos\Movie\MovieApp\MovieApp.UI\Views\Home\PartialPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
