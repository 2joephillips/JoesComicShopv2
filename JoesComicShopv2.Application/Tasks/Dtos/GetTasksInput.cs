using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPerson { get; set; }
    }
}
