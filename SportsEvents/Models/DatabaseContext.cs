using Microsoft.EntityFrameworkCore;

namespace SportsEvents.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
        public DbSet<Event> Events { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
