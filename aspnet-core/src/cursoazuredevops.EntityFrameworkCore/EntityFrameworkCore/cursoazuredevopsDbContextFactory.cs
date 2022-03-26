using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using cursoazuredevops.Configuration;
using cursoazuredevops.Web;

namespace cursoazuredevops.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class cursoazuredevopsDbContextFactory : IDesignTimeDbContextFactory<cursoazuredevopsDbContext>
    {
        public cursoazuredevopsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<cursoazuredevopsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            cursoazuredevopsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(cursoazuredevopsConsts.ConnectionStringName));

            return new cursoazuredevopsDbContext(builder.Options);
        }
    }
}
