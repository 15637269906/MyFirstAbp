using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.UserRoles;
using MyFirstAbp.UserRoles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{


    [Route("api/test")]
    public class UserRoleController : MyFirstAbpControllerBase
    {
        private IUserRoleService _IUserRoleService;
        public UserRoleController(IUserRoleService IUserRoleService) {
            _IUserRoleService = IUserRoleService;

        }

        [HttpGet]
        [Route("SearchAllUserRole")]
        public SearchAllUserRoleOutput SearchAllUserRole(SearchAllUserRoleInput input) {
            SearchAllUserRoleOutput s = _IUserRoleService.SearchAllUserRole(input);
            return s;
        }


      


    }
}
