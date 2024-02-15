using System.Threading.Tasks;
using TestXia.Models.TokenAuth;
using TestXia.Web.Controllers;
using Shouldly;
using Xunit;

namespace TestXia.Web.Tests.Controllers
{
    public class HomeController_Tests: TestXiaWebTestBase
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