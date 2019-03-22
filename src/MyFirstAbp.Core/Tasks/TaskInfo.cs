using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstAbp.Tasks
{
    public class TaskInfo : Entity<int>, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;

        public long? AssignePersonId { get; set; }

        public string aa { get; set; }

       

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title22 { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public TaskState State { get; set; }

        public DateTime CreationTime { get; set; }



       // public string jieshao { get; set; }




        public TaskInfo()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Open; ;
        }

        public TaskInfo(string title, string description = null) : this()
        {
            Title22 = title;
            Description = description;
        }

    }
    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}
