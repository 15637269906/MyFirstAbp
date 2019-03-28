using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.SysRoles;
using MyFirstAbp.SysRoles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{
     [Route("api/roles")]
    public class SysRoleController: MyFirstAbpControllerBase
    {
        private ISysRoleService _ISysRoleService;
        public SysRoleController(ISysRoleService ISysRoleService) {
            _ISysRoleService = ISysRoleService;
        }
        [HttpPost]
        [Route("AddRoles")]
        public AddRolesOutput  AddRoles(AddRolesIntput input) {
            AddRolesOutput s = _ISysRoleService.AddRoles(input);
            return s;
        }

        [HttpDelete]
        [Route("DeleteRoles")]
        public void DeleteRoles(int id) {
            _ISysRoleService.DeleteRoles(id);
        }

        [HttpGet]
        [Route("GetRolePageList")]
        public PagedResultDto<RolePageListDto> GetRolePageList(GetRolePageListInput input)
        {
            var result = _ISysRoleService.GetRolePageList(input);
            return result;
        }

    }
}
