﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.Tasks.Dtos
{
    public class TaskDto : Entity<long>
    {
        public int? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set;}

        public byte State { get; set; }
    }
}
