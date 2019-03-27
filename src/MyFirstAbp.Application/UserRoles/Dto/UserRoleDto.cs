using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserRoles.Dto
{
  public   class UserRoleDto:EntityDto
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }




    }
}
