using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VS.DLQ.Authorization.Roles;
using VS.DLQ.Authorization.Users;
using VS.DLQ.MultiTenancy;
using VS.DLQ.Fish;
using VS.DLQ.Rules;

namespace VS.DLQ.EntityFrameworkCore
{
    public class DLQDbContext : AbpZeroDbContext<Tenant, Role, User, DLQDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }

        public DLQDbContext(DbContextOptions<DLQDbContext> options)
            : base(options)
        {
        }
    }
}
