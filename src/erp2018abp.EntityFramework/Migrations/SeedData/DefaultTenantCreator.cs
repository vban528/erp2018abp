using System.Linq;
using erp2018abp.EntityFramework;
using erp2018abp.MultiTenancy;

namespace erp2018abp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly erp2018abpDbContext _context;

        public DefaultTenantCreator(erp2018abpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
