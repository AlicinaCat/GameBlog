using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GameBlog.Models
{
    public partial class Post
    {
        public Post()
        {
            PostCategories = new HashSet<PostCategories>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Title required.")]
        [StringLength(50, ErrorMessage = "The title cannot be longer than 50 characters.")]
        [DisplayName("Choose a title for your post.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You cannot leave the post empty.")]
        [StringLength(2000, ErrorMessage = "The post cannot be longer than 2000 characters.")]
        [DisplayName("Type in the content of your post.")]
        public string Content { get; set; }
        [DisplayName("Choose a category for your post.")]
        public int CategoryId { get; set; }
        public DateTime? Date { get; set; }

        public Category Category { get; set; }
        public ICollection<PostCategories> PostCategories { get; set; }
    }
}