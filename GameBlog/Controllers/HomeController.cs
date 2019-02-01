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
            var list = _context.Posts.ToList();
            var query = (from l in list
                         orderby l.Date descending
                         select l).ToList();

            PostViewModel model = new PostViewModel();
            model.AllPosts = query;

            foreach (var item in model.AllPosts)
            {
                item.Category = (_context.Categories.Where(c => c.Id == item.CategoryId).ToList()).SingleOrDefault();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PostViewModel values)
        {
            PostViewModel model = new PostViewModel();
            model.AllPosts = _context.Posts.Where(p => p.Title.Contains(values.SearchValue) || p.Category.Name.Contains(values.SearchValue)).ToList();

            ModelState.Clear();

            return View(model);
        }

        public IActionResult CreateNewPost()
        {
            var model = new PostViewModel();

            foreach (var item in _context.Categories)
            {
                model.AllCategories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
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

        public IActionResult ShowPost(int id)
        {
            var model = _context.Posts.SingleOrDefault(p => p.Id == id);
            model.Category = _context.Categories.SingleOrDefault(c => c.Id == model.CategoryId);

            return View(model);
        }
    }
}