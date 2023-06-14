using System.Linq;
using System.Runtime.CompilerServices;

namespace BookStore.Models.DataLayer
{
    public static class QueryExtensions
    {

        public static IQueryable<T> PageBy<T>(this IQueryable<T> items ,int pagenumber ,int pageszie)
        {
            return items
                .Skip((pagenumber - 1) * pageszie)
                .Take(pageszie);

        }
    }
}
