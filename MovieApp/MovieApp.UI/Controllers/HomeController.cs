using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Service;
using MovieApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieAppContext _context; //Context imiz tekrardan yenilensin her çalıştıgında
        public HomeController(MovieAppContext context) // startup yazdık
        {
            _context = context;
        }
        public IActionResult PartialPage(string p)
        {

            var values = from d in _context.Movies select d;           //sql sorgusu olmadan olurmu nasıl olur?
            if (!string.IsNullOrEmpty(p)) //p den gelen boş mu kontrolü
            {
                values = values.Where(x => x.MovieTitle.Contains(p));  //film başlıklarında p den gelen deger var ise listele
            }

            return PartialView("Index", values.ToList()); //values den gelenleri listele ve index de göster
        }
        public IActionResult Index()
        {

            var result = _context.Movies.ToList();



            return View(result);
        }

        public IActionResult GetIndex(int Id)
        {
            var res = _context.Movies.Find(Id); //res adında degişkenimize find metodu ile ıd degerimizi buldurduk 

            res.MovieCount += 1;
            _context.SaveChanges();


            return View(res); //ekrana dönsün dedik
        }


        [HttpPost]
        public IActionResult Ekle(comment c, Guest g) //tablomuzdan model adında parametre çağırıyoruz
        {

            var guest = _context.Guests.FirstOrDefault(x => x.GuestMail == g.GuestMail); //veri tabanındaki mail ile ekranda kullanıcının girdigi mail eşleşiyormu kontrolü
            if (guest == null) //mail kontrolu eger null ise buraya gir 
            {
                _context.Guests.Add(g); //yeni kullancıyı ekle
                _context.SaveChanges(); // degişiklikleri kaydet
            }
            guest = _context.Guests.FirstOrDefault(x => x.GuestMail == g.GuestMail); //eger yukarda eklendiyse tekrar konrol ettiriyoruz

            c.GuestId = guest.Id; //kontrolcümüzdeki Id yi yorumdaki kullanıcı ıd sine ekle
            c.commentTime = DateTime.Now; //şuanki zamanı al
            _context.comments.Add(c);
            _context.SaveChanges();

            return RedirectToAction("GetIndex", new { Id = c.MovieId });
        }                                           //GetIndex deki Id parametresini buraya çagırıyoruz


    }

}
