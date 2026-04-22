using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext   
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
    // DbSets (tables)
    public DbSet<User> Users { get; set; }
    public DbSet<Policy> Policies { get; set; }
    public DbSet<CustomerPolicy> CustomerPolicies { get; set; }
    public DbSet<Claim> Claims { get; set; }
}