using Abp.Domain.Repositories;
using JoesComicShopv2.People.Dtos;
﻿using System.Collections.Generic;
using AutoMapper;

namespace JoesComicShopv2.People
{
    public class PersonAppService : IPersonAppService //Optionally, you can derive from ApplicationService as we did for TaskAppService class.
    {
        private readonly IRepository<Person> _personRepository;

        //ABP provides that we can directly inject IRepository<Person> (without creating any repository class)
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public GetAllPeopleOutput GetAllPeople()
        {
            return new GetAllPeopleOutput
                   {
                       People = Mapper.Map<List<PersonDto>>(_personRepository.GetAllList())
                   };
        }
    }
}