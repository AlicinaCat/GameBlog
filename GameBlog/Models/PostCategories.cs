using System;
using System.Collections.Generic;

namespace GameBlog.Models
{
    public partial class PostCategories
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
        public Post Post { get; set; }
    }
}
