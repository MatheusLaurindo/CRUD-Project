using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Data;
using ProjetoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrud.Controllers
{
    public class UsersController : Controller
    {
        private readonly ProjetoCrudContext _context;
        public UsersController(ProjetoCrudContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var user = _context.User.ToList();
            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(int id)
        {
            var user = _context.User.Find(id);
            _context.User.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
