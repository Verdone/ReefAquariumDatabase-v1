using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReefAquariumDatabase.Models;

namespace ReefAquariumDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ReefAquariumDatabase.Models.Animal> Animal { get; set; }
    }
}