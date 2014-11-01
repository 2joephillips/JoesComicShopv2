using Abp.Application.Services;
using AutoMapper;
using JoesComicShopv2.People;
using JoesComicShopv2.Tasks.Dtos;
using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace JoesComicShopv2.Tasks
{

    public class TaskAppService : ApplicationService, ITaskAppService
    {
        //These members set in constructor using constructor injection.
        
        private readonly ITaskRepository _taskRepository;
        private readonly IPersonRepository _personRepository;
        
        /// <summary>
        ///In constructor, we can get needed classes/interfaces.
        ///They are sent here by dependency injection system automatically.
        /// </summary>
        public TaskAppService(ITaskRepository taskRepository, IPersonRepository personRepository)
        {
            _taskRepository     =   taskRepository;
            _personRepository   =   personRepository;
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            //Called specific GetAllWithPeople method of task Repository.
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPerson, input.State);
            
            //Used AutoMapper to automatically call convert List<Task> to List<TaskDto>.
            return new GetTasksOutput
            {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };
        }

        public void UpdateTask (UpdateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var task = _taskRepository.Get(input.TaskId);
        }

        public void CreateTask (CreateTaskInput input)
        {
            Logger.Info("Creating a task for input:" + input);

            var task = new Task { Description = input.Description };

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPersonId = input.AssignedPersonId.Value;
            }

            //saving entity with standard Insert method of repositories
            _taskRepository.Insert(task);
        }
    }
}
