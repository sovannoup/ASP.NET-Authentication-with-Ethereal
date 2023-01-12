using Exchange.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ConfirmToken> ConfirmToken { get; set; }
    }
}