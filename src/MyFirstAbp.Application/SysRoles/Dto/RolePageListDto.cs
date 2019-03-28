using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.SysRoles.Dto
{

    [AutoMap(typeof(SysRoles.SysRole))]
    public class RolePageListDto
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public AuthDto[] Auths { set; get; }
    }
}
