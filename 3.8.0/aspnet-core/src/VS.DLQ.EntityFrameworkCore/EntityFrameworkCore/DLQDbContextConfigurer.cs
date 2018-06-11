using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VS.DLQ.EntityFrameworkCore
{
    public static class DLQDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DLQDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DLQDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
