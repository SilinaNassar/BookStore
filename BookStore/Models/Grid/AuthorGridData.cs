using BookStore.Models.DomainModels;
using System.Text.Json.Serialization;
namespace BookStore.Models.Grid
{
    public class AuthorGridData :GridData
    {
        public AuthorGridData() => SortField = nameof(Author.FirstName);


        //sort flag

        [JsonIgnore]
        public bool IsSortByFirstName => SortField.EqualsNoCase(nameof(Author.FirstName));

    }
}
