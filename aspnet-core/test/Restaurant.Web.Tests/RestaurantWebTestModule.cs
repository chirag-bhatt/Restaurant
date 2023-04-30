using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Restaurant.EntityFrameworkCore;
using Restaurant.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Restaurant.Web.Tests
{
    [DependsOn(
        typeof(RestaurantWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RestaurantWebTestModule : AbpModule
    {
        public RestaurantWebTestModule(RestaurantEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RestaurantWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RestaurantWebMvcModule).Assembly);
        }
    }
}