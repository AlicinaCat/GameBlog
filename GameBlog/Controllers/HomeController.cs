using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameBlog.Models;
using GameBlog.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            //var model = _context.Categories.ToList();

            return View();
        }

        public IActionResult CreateNewPost()
        {
            var model = new PostViewModel();

            foreach (var item in _context.Categories)
            {
                model.AllCategories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString()});
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateNewPost(PostViewModel newPost)
        {
            DateTime date = DateTime.Now;
            newPost.CurrentPost.Date = date;
            _context.Post.Add(newPost.CurrentPost);
             
            _context.SaveChanges();

            return View("PostSubmitted", newPost);
        }
    }
}
