using FactoryPatternTraning.Abstracts;


namespace FactoryPatternTraning.Data
{
    public class DbContext : IDbContext
    {
        private string _connectionString;
        public DbContext(DbContextOptions options)
        {
            _connectionString = options.ConnectionString;
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public void OnConfiguration(DbContextOptions options)
        {
            _connectionString = options.ConnectionString;
        }
    }
}
