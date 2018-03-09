using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace erp2018abp.Tests
{
    [DependsOn(
        typeof(erp2018abpApplicationModule),
        typeof(erp2018abpDataModule),
        typeof(AbpTestBaseModule))]
    public class erp2018abpTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Registering fake services

            IocManager.IocContainer.Register(
                Component.For<IAbpZeroDbMigrator>()
                    .UsingFactoryMethod(() => Substitute.For<IAbpZeroDbMigrator>())
                    .LifestyleSingleton()
                );
        }
    }
}
