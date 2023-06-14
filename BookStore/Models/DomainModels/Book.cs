using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace BookStore.Models.DomainModels
{
    public class Book
    {
        // primary key property
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter the book title!")]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;


        [Range(1.0, 100000.0, ErrorMessage = "The book price should be in the range of 1-100000")]
        public double Price { get; set; }



        // foreign key property
        [Required(ErrorMessage = "Please pick genre")]

        public string GenreId { get; set; } = string.Empty;




        // navigation properties
        [ValidateNever]
        public Genre Genre { get; set; } = null!;
        public ICollection<Author> Authors { get; set; }



        // initialize navigation property collection in constructor
        public Book() => Authors = new HashSet<Author>();



    }
}
