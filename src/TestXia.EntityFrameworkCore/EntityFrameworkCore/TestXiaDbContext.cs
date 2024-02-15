using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestXia.Authorization.Roles;
using TestXia.Authorization.Users;
using TestXia.MultiTenancy;
using TestXia.TestCreateTable;
using TestXia.TestCreateTable2;

namespace TestXia.EntityFrameworkCore
{
    public class TestXiaDbContext : AbpZeroDbContext<Tenant, Role, User, TestXiaDbContext>
    {
        public virtual DbSet<TestCreateTable.TestCreateTable> TestCreateTable { get; set; }

        public virtual DbSet<TestCreateTable2.TestCreateTable2> TestCreateTable2 { get; set; }

        /* Define a DbSet for each entity of the application */

        public TestXiaDbContext(DbContextOptions<TestXiaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TestCreateTable2.TestCreateTable2>(b =>
            {
                b.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            });

        }
    }
}
