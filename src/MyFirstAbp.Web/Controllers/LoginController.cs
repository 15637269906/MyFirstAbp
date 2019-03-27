using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{
    [Route("api/user")]
    public class LoginController : MyFirstAbpControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        //查询验证
        [HttpGet]
        [Route("login")]
        public String Login(string name, string pwd)
        {

            string result;
            result = _loginService.Login(name, pwd);

            return result;
        }



        //删除用户
        [HttpDelete]
        [Route("delete_user")]
        public bool delete_user(int id)
        {
            
            bool result = false;
            result = _loginService.delete_user(id);

            return result;
        }




        //添加用户
        [HttpPost]
        [Route("add_user")]
        public bool add_user(string name, string pwd)
        {
            bool result = false;
            result = _loginService.add_user(name, pwd);
            return result;
        }





        //修改用户
        [HttpPut]
        [Route("update_user")]
        public string update_user(int  id, string username)
        {
            string end_name;
            end_name = _loginService.update_user(id, username);
            return end_name;
        }


    }
}
