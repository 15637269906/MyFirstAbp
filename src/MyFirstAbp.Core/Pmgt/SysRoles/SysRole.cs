using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Pmgt.SysRoles
{
 public   class SysRole:Entity<int>
    {
        //角色描述
        public string Description { get; set; }
        //角色名称
        public string Name { get; set; }

        public SysRole() { }
    }
}
