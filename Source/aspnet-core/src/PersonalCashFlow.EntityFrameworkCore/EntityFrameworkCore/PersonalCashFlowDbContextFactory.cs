using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PersonalCashFlow.Configuration;
using PersonalCashFlow.Web;

namespace PersonalCashFlow.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PersonalCashFlowDbContextFactory : IDesignTimeDbContextFactory<PersonalCashFlowDbContext>
    {
        public PersonalCashFlowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PersonalCashFlowDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PersonalCashFlowDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PersonalCashFlowConsts.ConnectionStringName));

            return new PersonalCashFlowDbContext(builder.Options);
        }
    }
}
