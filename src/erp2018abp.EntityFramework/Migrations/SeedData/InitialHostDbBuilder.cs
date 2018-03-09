using erp2018abp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace erp2018abp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly erp2018abpDbContext _context;

        public InitialHostDbBuilder(erp2018abpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
