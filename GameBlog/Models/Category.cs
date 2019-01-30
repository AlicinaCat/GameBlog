using System;
using System.Collections.Generic;

namespace GameBlog.Models
{
    public partial class Category
    {
        public Category()
        {
            PostCategories = new HashSet<PostCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostCategories> PostCategories { get; set; }
    }
}
