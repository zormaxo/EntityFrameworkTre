using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkNet5.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
