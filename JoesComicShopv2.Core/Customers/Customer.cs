using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.Customers
{
    [Table("Customers")]
    public class Customer : Entity
    {
        public virtual string       Email               { get; set; }
        public virtual string       Username            { get; set; }
        public virtual string       Password            { get; set; }
        public virtual string       FirstName           { get; set; }
        public virtual string       LastName            { get; set; }
        public virtual DateTime?    DateOfBirth         { get; set; }
        public virtual DateTime     RegistrationDate    { get; set; }
        public virtual DateTime?    LastLoginDate       { get; set; }
    }
}
