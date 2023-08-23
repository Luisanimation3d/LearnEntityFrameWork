using Crud_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Entity.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }

}
