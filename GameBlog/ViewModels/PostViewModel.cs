using System;
using GameBlog.Models;
using System.ComponentModel;
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
        public List<Post> AllPosts { get; set; }
        [DisplayName("Search post via title: ")]
        public string SearchValue { get; set; }

        public PostViewModel()
        {
            PostCategories = new List<Category>();
            AllCategories = new List<SelectListItem>();
            AllPosts = new List<Post>();
        }
    }
}
