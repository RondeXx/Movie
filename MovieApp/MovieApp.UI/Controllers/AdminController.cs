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

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult List()
        {
            var result = _context.Movies.ToList();
            return View(result);
        }

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

        public IActionResult Edit(int Id)
        {

            var result = _context.Movies.Find(Id);

            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Movy movie, IFormFile image, IFormFile video)
        {
            //Entities modified update
            if (image == null && video == null)
            {
                return RedirectToAction("Edit");
            }
            else
            {
                string url = _webHostEnvironment.WebRootPath + movie.MovieImage; //tüm dosyanın a dan z ye tüm yolunu bul ve image yolunu ekle
                FileHelper.DeleteFile(url); // tüm bulunan yolu url paramtresi gönder delet helperine sonra sil
                url = _webHostEnvironment.WebRootPath + movie.MovieVideo;
                FileHelper.DeleteFile(url);

                movie.MovieImage = FileHelper.UploadFile(image, "images"); //iki tane parametre isityor biri file digeri yolu
                movie.MovieVideo = FileHelper.UploadFile(video, "videos");
                _context.Entry(movie).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("List");
            }
        }

        public IActionResult Update(int Id)
        {
            var result = _context.Movies.Find(Id);
            return View(result);
        }

        public IActionResult Add()
        {
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

    }
}



