using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.RoleAuths
{
    public class RoleAuth : Entity<int>
    {
        //权限id
        public int  AuthId { get; set; }
        //角色id
        public  int RoleId{get;set;}
        public RoleAuth() { }


    }
}
