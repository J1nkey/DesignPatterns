using FactoryPatternTraning.Abstracts;
using FactoryPatternTraning.Data;
using FactoryPatternTraning.Extensions;
using Microsoft.Extensions.Configuration;

namespace FactoryPatternTraning.Factories
{
    public class DbContextFactory
    {
        private const string DEFAULT_CONNECTION_STRING_SECTION = "Default";
        private IConfiguration _configuration;

        public DbContextFactory()
        {
            AddConfiguration();
        }

        public IDbContext CreateDbContext(string? connectionString)
        {
            var options = new DbContextOptions();

            if(connectionString == null)
            {
                return CreateDbContext();
            }

            options.UseSqlServer(connectionString);
            return new DbContext(options);
        }

        public DbContext CreateDbContext()
        {
            var options = new DbContextOptions();

            var internalConnectionString = _configuration.GetConnectionString(DEFAULT_CONNECTION_STRING_SECTION);
            options.UseSqlServer(internalConnectionString);

            return new DbContext(options);
        }

        private void AddConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // This is using builder pattern
            _configuration = builder.Build();
        }
    }
}
