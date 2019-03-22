using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyFirstAbp.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Persons
{
    public class LoginService : ApplicationService, ILoginService
    {
        private readonly IRepository<User> _taskRepository;

        /// <summary>
        ///In constructor, we can get needed classes/interfaces.
        ///They are sent here by dependency injection system automatically.
        /// </summary>
        public LoginService(IRepository<User> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool Login(string name, string pwd)
        {
            bool result = false;
           /* var a = _taskRepository.InsertAndGetId(new User()
            {
                username=name,
                password=pwd
            });
            System.Console.WriteLine(a);
            */
             var users= _taskRepository.FirstOrDefault(o => o.username == name&&o.password==pwd);

            if (users != null){
                return true;
            }



            // _taskRepository.Delete(o => o.Id > 2);



            //_taskRepository.Update(ta);

            //  TaskInfo tt= _taskRepository.Update(2, Action<TaskInfo> );



            //var info = _taskRepository.FirstOrDefault(o => o.Id == 2);

     
            /* info.Title22 = "水水水水";
            info.Description = "啊啊啊";*/
            return result;

        }
    }
}
