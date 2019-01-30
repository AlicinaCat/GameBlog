using System;
using System.Collections.Generic;

namespace GameBlog.Models
{
    public partial class Post
    {
        public Post()
        {
            PostCategories = new HashSet<PostCategories>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public ICollection<PostCategories> PostCategories { get; set; }
    }
}
