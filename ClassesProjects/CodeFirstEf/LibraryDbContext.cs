using Microsoft.EntityFrameworkCore;

namespace CodeFirstEf;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=Library;User ID=sa;Password=password-1234;Encrypt=False");
    }
}