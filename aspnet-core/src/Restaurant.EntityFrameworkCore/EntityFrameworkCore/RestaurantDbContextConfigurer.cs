using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.EntityFrameworkCore
{
    public static class RestaurantDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RestaurantDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RestaurantDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
