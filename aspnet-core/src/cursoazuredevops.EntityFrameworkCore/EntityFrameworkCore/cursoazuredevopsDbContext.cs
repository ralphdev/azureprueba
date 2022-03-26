using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using cursoazuredevops.Authorization.Roles;
using cursoazuredevops.Authorization.Users;
using cursoazuredevops.MultiTenancy;

namespace cursoazuredevops.EntityFrameworkCore
{
    public class cursoazuredevopsDbContext : AbpZeroDbContext<Tenant, Role, User, cursoazuredevopsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public cursoazuredevopsDbContext(DbContextOptions<cursoazuredevopsDbContext> options)
            : base(options)
        {
        }
    }
}
