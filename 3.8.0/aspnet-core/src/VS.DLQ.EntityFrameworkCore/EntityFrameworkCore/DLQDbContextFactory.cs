using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VS.DLQ.Configuration;
using VS.DLQ.Web;

namespace VS.DLQ.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DLQDbContextFactory : IDesignTimeDbContextFactory<DLQDbContext>
    {
        public DLQDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DLQDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DLQDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DLQConsts.ConnectionStringName));

            return new DLQDbContext(builder.Options);
        }
    }
}
