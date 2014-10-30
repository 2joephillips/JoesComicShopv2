using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace JoesComicShopv2.People
{

    [Table("StsPeople")]
    public class Person : Entity
    {
        /// <summary>
        /// A property (database field) for a Person to store his/her name.
        /// NOTE: NHibernate requires that all members of an entity must be virtual (for proxying purposes)!
        /// </summary>
        public virtual string Name { get; set; }
    }
}
