using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace erp2018abp.EntityFramework.Repositories
{
    public abstract class erp2018abpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<erp2018abpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected erp2018abpRepositoryBase(IDbContextProvider<erp2018abpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class erp2018abpRepositoryBase<TEntity> : erp2018abpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected erp2018abpRepositoryBase(IDbContextProvider<erp2018abpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
