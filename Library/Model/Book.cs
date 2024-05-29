using System.ComponentModel.DataAnnotations;

namespace Library.Model
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(30,MinimumLength = 2, ErrorMessage = "Title should be between 2 and 30 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Author is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Author should be between 2 and 200 characters")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Description should be between 2 and 200 characters")]

        public string Description { get; set; } = string.Empty ;

        public DateTime publishedDate { get; set; }
    }
}
