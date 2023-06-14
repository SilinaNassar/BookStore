using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace BookStore.Models.DomainModels
{
    public class Author
    {

        // primary key property
        public int AuthorId { get; set; }


        [Required(ErrorMessage = "Please enter the first name!")]
        [MaxLength(200)]

        public string FirstName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter the last name!")]
        [MaxLength(200)]

        public string LastName { get; set; } = string.Empty;


        // read-only property
        public string FullName => $"{FirstName} {LastName}";

        // navigation property
        public ICollection<Book> Books { get; set; }




        // initialize navigation property collection in constructor
        public Author() => Books = new HashSet<Book>();





    }
}
