using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace JoesComicShopv2.EntityFramework.Repositories
{
    public abstract class JoesComicShopv2RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JoesComicShopv2DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class JoesComicShopv2RepositoryBase<TEntity> : JoesComicShopv2RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
