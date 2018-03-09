using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using erp2018abp.EntityFramework;

namespace erp2018abp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(erp2018abpCoreModule))]
    public class erp2018abpDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<erp2018abpDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
