using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Restaurant.Authorization.Roles;
using Restaurant.Authorization.Users;
using Restaurant.MultiTenancy;

namespace Restaurant.EntityFrameworkCore
{
    public class RestaurantDbContext : AbpZeroDbContext<Tenant, Role, User, RestaurantDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }
    }
}
