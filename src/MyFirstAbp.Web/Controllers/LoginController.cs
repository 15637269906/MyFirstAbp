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

        [HttpGet]
        [Route("login")]
        public bool Login(string name, string pwd)
        {
            bool result = false;
            result = _loginService.Login(name, pwd);
            return result;
        }
    }
}
