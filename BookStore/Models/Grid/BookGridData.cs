using BookStore.Models.DomainModels;
using System.Text.Json.Serialization;
namespace BookStore.Models.Grid
{
    public class BookGridData :GridData
    {
        //set initial sort field in constructor

        public BookGridData() => SortField = nameof(Book.Title);


        //sort flag

        [JsonIgnore]
        public bool IsSortByGenre => SortField.EqualsNoCase(nameof(Genre));

        [JsonIgnore]
        public bool IsSortByPrice => SortField.EqualsNoCase(nameof(Book.Price));
    }
}
