using Abp.Application.Services;
using JoesComicShopv2.People.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.People
{
        public interface IPersonAppService : IApplicationService
        {
            GetAllPeopleOutput GetAllPeople();
        }
}
