using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.Persons;
using MyFirstAbp.Userservice;
using MyFirstAbp.Userservice.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{
    [Route("api/filter")]
    public class UserController : MyFirstAbpControllerBase
    {

        private IUsersService  _UsersService;
        public UserController(IUsersService UsersService) {
            _UsersService = UsersService;
        }
        [HttpGet]
        [Route("login")]
        public string login(SearchUserInput input) {
            SearchUserOutput  output= _UsersService.SearchUser(input);
            var end_list = output.User;
            return end_list.ToString();
        }



    }
}
