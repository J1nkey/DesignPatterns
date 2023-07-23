namespace FactoryPatternTraning.Extensions
{
    public static class DbContextOptionsExtensions
    {
        public static DbContextOptions UseSqlServer(this DbContextOptions options, string connectionString)
        {
            options.ConnectionString = connectionString;
            return options;
        }
    }
}
