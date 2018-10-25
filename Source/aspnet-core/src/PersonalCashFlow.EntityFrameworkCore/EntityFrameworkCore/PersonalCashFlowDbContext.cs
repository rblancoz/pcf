using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PersonalCashFlow.Authorization.Roles;
using PersonalCashFlow.Authorization.Users;
using PersonalCashFlow.MultiTenancy;

namespace PersonalCashFlow.EntityFrameworkCore
{
    public class PersonalCashFlowDbContext : AbpZeroDbContext<Tenant, Role, User, PersonalCashFlowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PersonalCashFlowDbContext(DbContextOptions<PersonalCashFlowDbContext> options)
            : base(options)
        {
        }
    }
}
