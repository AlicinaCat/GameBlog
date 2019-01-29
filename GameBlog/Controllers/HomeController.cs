using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameBlog.Models;
using GameBlog.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameBlog.Controllers
{
    public class HomeController : Controller
    {
        private BlogDBContext _context;

        public HomeController(BlogDBContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Categories.ToList();
            
            return View(model);
        }

        public IActionResult CreateNewPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewPost(PostViewModel newPost)
        {
            _context.Post.Add(newPost.CurrentPost);      //TODO Hellooo what about the categories??? 
            _context.SaveChanges();

            ModelState.Clear();

            return View();
        }
    }
}
