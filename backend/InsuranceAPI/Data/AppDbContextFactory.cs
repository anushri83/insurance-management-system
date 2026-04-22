using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

// Design-time factory to allow EF tools to create AppDbContext when running commands like
// `dotnet ef migrations add` or `dotnet ef database update`.
// It reads connection string from the DEV_DEFAULT_CONNECTION environment variable if set,
// otherwise falls back to the LocalDB connection used in appsettings.json.
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("DEV_DEFAULT_CONNECTION");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=InsuranceDb;Trusted_Connection=True;";
        }

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new AppDbContext(optionsBuilder.Options);
    }
}
