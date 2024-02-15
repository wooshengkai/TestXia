using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestXia.Configuration;
using TestXia.Web;

namespace TestXia.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestXiaDbContextFactory : IDesignTimeDbContextFactory<TestXiaDbContext>
    {
        public TestXiaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestXiaDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestXiaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestXiaConsts.ConnectionStringName));

            return new TestXiaDbContext(builder.Options);
        }
    }
}
