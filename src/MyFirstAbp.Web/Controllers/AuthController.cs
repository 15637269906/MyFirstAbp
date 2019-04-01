using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.Auths;

using MyFirstAbp.Auths.Dto;
using MyFirstAbp.Pmgt.SysRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{

    [Route("api/basic")]
    public class AuthController : MyFirstAbpControllerBase
    {
        private  IAuthService _IAuthService;
            public AuthController(IAuthService IAuthService) {
            _IAuthService = IAuthService;
        }

        [HttpGet]
        [Route("auths")]
        public GetAllAuthsOutput auths(){
            GetAllAuthsOutput s = _IAuthService.GetAllAuths();
            return s;
            }

 




    }
}
