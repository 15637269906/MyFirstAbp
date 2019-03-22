using MyFirstAbp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Tasks
{
    public class DefaultTestDataForTask
    {

        private readonly MyFirstAbpDbContext _context;
        private static readonly List<TaskInfo> _tasks;

        public DefaultTestDataForTask(MyFirstAbpDbContext context)
        {
            _context = context;
        }

        static DefaultTestDataForTask()
        {
            _tasks = new List<TaskInfo>()
            {
                new TaskInfo("Learning ABP deom","Learning how to use abp framework to build a MPA application."),
                new TaskInfo ("Make Lunch","Cook 2 dishs")
            };
        }

        public void Create()
        {
            foreach (var task in _tasks)
            {
                _context.TaskInfo.Add(task);
                _context.SaveChanges();
            }
        }
    }
}
