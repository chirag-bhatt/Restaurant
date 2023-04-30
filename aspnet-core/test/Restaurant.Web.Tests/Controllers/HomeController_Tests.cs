using System.Threading.Tasks;
using Restaurant.Models.TokenAuth;
using Restaurant.Web.Controllers;
using Shouldly;
using Xunit;

namespace Restaurant.Web.Tests.Controllers
{
    public class HomeController_Tests: RestaurantWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}