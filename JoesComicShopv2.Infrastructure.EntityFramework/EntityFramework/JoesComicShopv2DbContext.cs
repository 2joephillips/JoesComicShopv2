using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;
using JoesComicShopv2.People;
using JoesComicShopv2.Tasks;

namespace JoesComicShopv2.EntityFramework
{
    public class JoesComicShopv2DbContext : AbpDbContext
    {
        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> People { get; set; }

        public JoesComicShopv2DbContext()
            : base("MainDb")
        {

        }

        public JoesComicShopv2DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().ToTable("StsPeople");
            modelBuilder.Entity<Task>().ToTable("StsTasks").HasOptional(t => t.AssignedPerson);
        }
    }
}
