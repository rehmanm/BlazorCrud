using BlazorCrud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
    }
}
