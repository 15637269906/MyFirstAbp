using Abp.Application.Services;
using MyFirstAbp.Userservice.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Userservice
{
    public  interface IUsersService : IApplicationService
    {
     SearchUserOutput SearchUser(SearchUserInput input);
    }
}
