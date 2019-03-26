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
        /// 


        /*----------------------查询验证---------------------------------------*/
        public string Login(string name, string pwd)
        {
            /* var a = _taskRepository.InsertAndGetId(new User()
             {
                 username=name,
                 password=pwd
             });
             System.Console.WriteLine(a);
             */
            var usres = _taskRepository.FirstOrDefault(o => o.username == name);
            if (usres != null) {
                if (usres.password == pwd)
                {
                    return "存在该用户，登录成功";
                }
                else {
                    return "存在该用户，密码错误";
                }
            }

         /*    var users= _taskRepository.FirstOrDefault(o => o.username == name&&o.password==pwd);
            if (users != null){
                return "存在该用户，登录成功";
            }
            */
            // _taskRepository.Delete(o => o.Id > 2);
            //_taskRepository.Update(ta);
            //  TaskInfo tt= _taskRepository.Update(2, Action<TaskInfo> );
            //var info = _taskRepository.FirstOrDefault(o => o.Id == 2);
            /* info.Title22 = "水水水水";
            info.Description = "啊啊啊";*/
            return "不存在该用户，登录失败";

        }


       /*----------------------删除---------------------------------------*/

          public  bool delete_user(int id) {
            bool result = false;
            _taskRepository.Delete(id);
            return result;
        }


        /*----------------------新增---------------------------------------*/


        public  bool add_user(string usernmae, string password) {
            bool result = false;
            //User u = new User(usernmae, password);
            var i = _taskRepository.InsertAndGetId(new User() {
                username = usernmae,
            password = password

         });
         
            return result;
        }


        public string update_user(int id, string username) {
            User u = new User();
            u.Id = id;
            u.username = username;
         var end_user= _taskRepository.Update(u);
            return end_user.username;
        }//修改






    }







}
