using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace cursoazuredevops.EntityFrameworkCore
{
    public static class cursoazuredevopsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<cursoazuredevopsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<cursoazuredevopsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
