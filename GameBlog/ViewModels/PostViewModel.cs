using System;
using GameBlog.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameBlog.ViewModels
{
    public class PostViewModel
    {
        public Post CurrentPost { get; set; }
        public List<Category> PostCategories { get; set; }
        public List<SelectListItem> AllCategories { get; set; }
        public int CategoryId { get; set; }
        //public DateTime PostDate { get; set; }

        public PostViewModel()
        {
            PostCategories = new List<Category>();
            AllCategories = new List<SelectListItem>();
        }
    }
}
