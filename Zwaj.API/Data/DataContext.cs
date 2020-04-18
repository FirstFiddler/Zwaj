using Microsoft.EntityFrameworkCore;
using Zwaj.API.Models;

namespace Zwaj.API.Data
{
    public class DataContext:DbContext
    {
         public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
        
       
    }
}