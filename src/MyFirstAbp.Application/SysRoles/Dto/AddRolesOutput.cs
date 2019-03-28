using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.SysRoles.Dto
{
    public class AddRolesOutput
    {
        public int Id { set; get; }
        public string Name { set; get; }
       public AuthDto[] Auths { set; get; }

    }
}
