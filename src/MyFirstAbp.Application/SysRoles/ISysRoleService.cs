using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstAbp.SysRoles.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.SysRoles
{
   public  interface ISysRoleService:IApplicationService
    {
        AddRolesOutput AddRoles(AddRolesIntput input);

        void DeleteRoles(int id);

        PagedResultDto<RolePageListDto> GetRolePageList(GetRolePageListInput input);


        AddRolesOutput UpdateSysRole(UpdateSysRoleInput input);







    }
}
