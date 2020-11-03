using Microsoft.EntityFrameworkCore;

namespace PatientsRegistration
{
    //Контекст Record
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        public RecordContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PatientsRegistration;Username=postgres;Password=postgres");
        }
    }
}
