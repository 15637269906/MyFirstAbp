using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstAbp.Userservice.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Userservice
{
    public  interface IUsersService : IApplicationService
    {

        //查找
     SearchUserOutput SearchUser(SearchUserInput input);


        //分页实现
        PagedResultDto<UserDto> GetPagedUsers(GetUserInput input);


    }
}
