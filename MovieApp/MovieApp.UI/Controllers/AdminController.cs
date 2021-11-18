using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Service.Models;
using MovieApp.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly MovieAppContext _context; //Context imiz tekrardan yenilensin her çalıştıgında
        public AdminController(MovieAppContext context, IWebHostEnvironment webHostEnvironment) // startup yazdık
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        //       <!---------------------------------------------!>
        public IActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            if (new AdminHelper().IsLoginSuccess(admin)) //Helpımızı çagırdık adminhelp  içindeki "IsLoginSuccess" metodunu çalıştır admin paramatresini gönder yani ekrandan gelen degerleri
            {
                return RedirectToAction("List", "Admin");
            }


            return RedirectToAction("Index", "Admin");
        }
        //       <!---------------------------------------------!>
        public IActionResult List()
        {
            var result = _context.Movies.ToList();
            return View(result);
        }
        //       <!---------------------------------------------!>
        public IActionResult Delete(int Id)
        {
            var result = _context.Movies.Find(Id);
            _context.Movies.Remove(result);

            string url = _webHostEnvironment.WebRootPath + result.MovieImage;
            //dosyanın tüm yolunu aldık hatasız silmek için
            FileHelper.DeleteFile(url);


            _context.SaveChanges();
            return RedirectToAction("List");
        }
        //       <!---------------------------------------------!>
        public IActionResult Edit(int Id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var result = _context.Movies.Find(Id);

            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Movy movie, IFormFile image, IFormFile video)
        {
            //Entities modified update

           
           

            if (image != null)
            {
                string url = _webHostEnvironment.WebRootPath + movie.MovieImage; //tüm dosyanın a dan z ye tüm yolunu bul ve image yolunu ekle

                FileHelper.DeleteFile(url);

                movie.MovieImage = FileHelper.UploadFile(image, "images");
            }

            if (video != null)
            {
                string url = _webHostEnvironment.WebRootPath + movie.MovieVideo; //tüm dosyanın a dan z ye tüm yolunu bul ve image yolunu ekle

                FileHelper.DeleteFile(url);

                movie.MovieVideo = FileHelper.UploadFile(video, "videos");
            }


            _context.Entry(movie).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        //       <!---------------------------------------------!>
        public IActionResult Update(int Id)
        {
            var result = _context.Movies.Find(Id);
            return View(result);
        }
        //       <!---------------------------------------------!>
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Directors = _context.Directors.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movy model, IFormFile image, IFormFile video)
        {
            if (image == null && video == null)
            {
                return RedirectToAction("Add");
            }
            else
            {
                model.MovieImage = FileHelper.UploadFile(image, "images");
                model.MovieVideo = FileHelper.UploadFile(video, "videos");

                _context.Movies.Add(model);

                _context.SaveChanges();
                return RedirectToAction("List");
            }
        }
        //       <!---------------------------------------------!>
        public IActionResult MovieActorAdd(int Id)
        {
            var result = _context.Movies.Find(Id);
            var list = new List<Actor>();
            foreach (var item in _context.Actors)
            {
                if (item.Movies.Contains(result) == false)
                {
                    list.Add(item);
                }
            }
            ViewBag.List = list;

            return View(result);

        }

        [HttpPost]
        public IActionResult MovieActorAdd(int ActorsId, int Id)
        {
            var actor = _context.Actors.Find(ActorsId);
            var movie = _context.Movies.Find(Id);

            if (actor != null & movie != null)
            {
                movie.Actors.Add(actor);
                _context.SaveChanges();

                return View(new { Id = movie.Id });
            }
            return RedirectToAction("MovieActorAdd", "Admin", new { Id = movie.Id });

        }
        //       <!---------------------------------------------!>
        public IActionResult MovieDirectorAdd(int Id)
        {
            var result = _context.Movies.Find(Id);
            var list = new List<Director>();
            foreach (var item in _context.Directors)
            {
                if (item.Movies.Contains(result) == false)
                {
                    list.Add(item);
                }
            }
            ViewBag.Listi = list;

            return View(result);
        }
        [HttpPost]
        public IActionResult MovieDirectorAdd(int DirectorId, int Id)
        {
            var director = _context.Directors.Find(DirectorId);
            var movie = _context.Movies.Find(Id);

            if (director != null & movie != null)
            {
                movie.Directors.Add(director);
                _context.SaveChanges();
            }


            return RedirectToAction("MovieDirectorAdd", "Admin", new { Id = movie.Id });

        }
    }
}



