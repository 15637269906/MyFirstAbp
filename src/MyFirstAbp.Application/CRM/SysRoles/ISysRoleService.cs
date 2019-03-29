using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstAbp.CRM.SysRoles.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.CRM.SysRoles
{
   public  interface ISysRoleService:IApplicationService
    {
        AddRolesOutput AddRoles(AddRolesIntput input);

        void DeleteRoles(int id);

        PagedResultDto<RolePageListDto> GetRolePageList(GetRolePageListInput input);

    }
}
