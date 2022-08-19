using Entities.Concrates;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class BookContext:DbContext
    {
        public BookContext():base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0V8VD7E\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Book> Books { get; set; }




    }
}
