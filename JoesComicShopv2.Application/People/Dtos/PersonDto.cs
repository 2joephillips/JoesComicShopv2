using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace JoesComicShopv2.People.Dtos
{
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
    }
}
