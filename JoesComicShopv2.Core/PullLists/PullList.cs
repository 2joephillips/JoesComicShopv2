using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using JoesComicShopv2.Comics;
using JoesComicShopv2.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.PullLists
{
    [Table("PullLists")]
    public class PullList : Entity<long>, IHasCreationTime
    {
        public PullList()
        {
            CreationTime = DateTime.Now;
        }

        [ForeignKey("AssignedCustomerId")]
        public virtual Customer AssignedCustomer { get; set; }
        public virtual int? AssignedCustomerId { get; set; }

        [ForeignKey("SelectedCustomerId")]
        public virtual Comic SelectedComic { get; set; }
        public virtual int? SelectedComicId { get; set; }

        public virtual DateTime PickUpDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }
        public virtual DateTime CreationTime { get; set; }

    }
}
