using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions option) : base(option)
        {
            
        }
        public DbSet<Activity> Activities { get; set; }
    }
}