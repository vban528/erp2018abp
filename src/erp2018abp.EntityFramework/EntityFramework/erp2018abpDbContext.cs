using System.Data.Common;
using Abp.Zero.EntityFramework;
using erp2018abp.Authorization.Roles;
using erp2018abp.Authorization.Users;
using erp2018abp.MultiTenancy;

namespace erp2018abp.EntityFramework
{
    public class erp2018abpDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public erp2018abpDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in erp2018abpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of erp2018abpDbContext since ABP automatically handles it.
         */
        public erp2018abpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public erp2018abpDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public erp2018abpDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
