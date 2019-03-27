using Abp.Application.Services;
using MyFirstAbp.UserRoles.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserRoles
{
    public interface IUserRoleService : IApplicationService
    {
        SearchAllUserRoleOutput SearchAllUserRole(SearchAllUserRoleInput input);

    }
}
