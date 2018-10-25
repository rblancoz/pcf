using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PersonalCashFlow.EntityFrameworkCore
{
    public static class PersonalCashFlowDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PersonalCashFlowDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PersonalCashFlowDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
