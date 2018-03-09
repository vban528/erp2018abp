using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using erp2018abp.EntityFramework;

namespace erp2018abp.Migrator
{
    [DependsOn(typeof(erp2018abpDataModule))]
    public class erp2018abpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<erp2018abpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}