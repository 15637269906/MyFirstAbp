using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.SysRoles.Dto
{
  public  class UpdateSysRoleInput
    {
        public int id { set; get; }
            public string name { set; get; }
        public int[] auths { set; get; }

    }
}
