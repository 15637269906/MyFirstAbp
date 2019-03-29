using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.CRM.SysRoles.Dto
{
    public class AddRolesOutput
    {
        public int Id { set; get; }
        public string Name { set; get; }
       public AuthDto[] Auths { set; get; }

    }
}
