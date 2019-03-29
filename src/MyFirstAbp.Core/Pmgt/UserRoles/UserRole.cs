using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Pmgt.UserRoles
{
    public class UserRole:Entity<int>
    {
        //角色id
        public int RoleId { set; get; }
        //用户id
        public int UserId { set; get; }


        public UserRole() { }

    }
}
