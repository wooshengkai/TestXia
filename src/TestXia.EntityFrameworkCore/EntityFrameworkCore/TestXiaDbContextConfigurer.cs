using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestXia.EntityFrameworkCore
{
    public static class TestXiaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestXiaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestXiaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
