using System.Linq;
using Abp.Application.Editions;
using erp2018abp.Editions;
using erp2018abp.EntityFramework;

namespace erp2018abp.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly erp2018abpDbContext _context;

        public DefaultEditionsCreator(erp2018abpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}