using BookStore.Models.DomainModels;
using BookStore.Models.Grid;

namespace BookStore.Models.ViewModels
{
    public class BookListViewModel
    {

        public IEnumerable<Book> Books { get; set; } =new List<Book>();

        public BookGridData CurrentRoute { get; set; } =new BookGridData();

        public int TotalPages { get; set; }
    }
}
