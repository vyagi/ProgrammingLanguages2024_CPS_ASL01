using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst
{
    public class UniversityDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=University;User ID=sa;Password=password-1234;Encrypt=False;Trust Server Certificate=True");
        }
    }
}
