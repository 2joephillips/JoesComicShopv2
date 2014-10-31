using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.People
{
    class PersonAppService: IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public GetAllPeopleOutPut GetAllPeople()
        {
            return new GetAllPeopleOutPut
            {
                People = AutoMapper.Mapper<List<PersonDto>>(_personRepository.GetAllList())
            };
        }
    }
}
