using BookStore.Controllers;
using BookStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookStoreContext: DbContext
    {
        public DbSet<Genre> Genres { get; set; } = null;
        public DbSet<Book> Books { get; set; } = null;

        public DbSet<Author> Authors { get; set; } = null;

        

        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigureGenre());
            modelBuilder.ApplyConfiguration(new ConfigureAuthors());
            modelBuilder.ApplyConfiguration(new ConfigureBookAuthors());
            modelBuilder.ApplyConfiguration(new ConfigureBooks());
        }
    }
}
