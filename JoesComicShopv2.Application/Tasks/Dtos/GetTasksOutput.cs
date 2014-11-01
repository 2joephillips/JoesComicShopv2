using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.Tasks.Dtos
{
    public class GetTasksOutput : IOutputDto
    {
        public List<TaskDto> Tasks { get; set; }
    }
}
