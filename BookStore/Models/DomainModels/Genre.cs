using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Models.DomainModels
{
    public class Genre
    {
        // primary key property
        [MaxLength(10)]
        [Required(ErrorMessage = "Enter the genre Id!")]
        public string GenreId { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter the genre name!")]
        [MaxLength(25)]

        public string Name { get; set; } = string.Empty;

        // navigation property
        public ICollection<Book> Books { get; set; }

        // initialize navigation property collection in constructor
        public Genre() => Books = new HashSet<Book>();




    }
}
