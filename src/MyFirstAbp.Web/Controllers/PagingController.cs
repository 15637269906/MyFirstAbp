using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.Userservice;
using MyFirstAbp.Userservice.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{
    [Route("api/paging")]
    public class PagingController : MyFirstAbpControllerBase
    {
        private IUsersService _UsersService;

        public PagingController(IUsersService UsersService) {
            _UsersService = UsersService;
        }


        [HttpGet]
        [Route("PagedList")]
        public PagedResultDto<UserDto>  PagedList(int? page,int?  size) {
            var pageSize = size ?? 5;
            var pageNumber = page ?? 1;
            var filter = new GetUserInput
            {
                SkipCount=(pageNumber-1)*pageSize,
                MaxResultCount=pageSize
            };
            var result = _UsersService.GetPagedUsers(filter);
            return result;
                
            }

    }
}
