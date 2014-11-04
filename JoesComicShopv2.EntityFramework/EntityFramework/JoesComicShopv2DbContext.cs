using Abp.EntityFramework;
using JoesComicShopv2.Comics;
using JoesComicShopv2.Customers;
using JoesComicShopv2.PullLists;
using System.Data.Entity;

namespace JoesComicShopv2.EntityFramework
{
    public class JoesComicShopv2DbContext : AbpDbContext
    {
        public virtual IDbSet<Comic> Comics { get; set; }
        public virtual IDbSet<PullList> PullLists { get; set; }
        public virtual IDbSet<Customer> Customers { get; set; }

        public JoesComicShopv2DbContext()
            : base("Default")
        {

        }


        public JoesComicShopv2DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
