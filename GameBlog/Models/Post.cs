using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GameBlog.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        [DisplayName("Insert a title for your post (max 50 characters):")]
        public string Title { get; set; }
        [DisplayName("Here you can type in your post (max 2000 character):")]
        public string Content { get; set; }
    }
}
