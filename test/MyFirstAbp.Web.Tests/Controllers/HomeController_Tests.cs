using System.Threading.Tasks;
using MyFirstAbp.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyFirstAbp.Web.Tests.Controllers
{
    public class HomeController_Tests: MyFirstAbpWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
