using Microsoft.AspNetCore.Mvc;
using MovieApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.UI.Controllers
{
    public class AdminController : Controller
    {

        private readonly MovieAppContext _context; //Context imiz tekrardan yenilensin her çalıştıgında
        public AdminController(MovieAppContext context) // startup yazdık
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult List()
        {
        var result =_context.Movies.ToList();
            return View(result);
        }

        public IActionResult Delete(int Id)
            {
            _context.Movies.Remove(_context.Movies.Find(Id));
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            var result = _context.Movies.Find(Id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Movy movie, int Id)
        {
            _context.Entry(movie).State = EntityState.Modified; //Entities modified update
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Update(int Id)
        {
            var result = _context.Movies.Find(Id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Add(Movy model)
        {
            _context.Movies.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}



