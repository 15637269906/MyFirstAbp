using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyFirstAbp.CRM.SysRoles.Dto
{
  public  class GetRolePageListInput
    {
        public string key { get; set; }
        [DefaultValue(1)]
        public int page { get; set; }
        [DefaultValue(5)]
        public int pageCount { get; set; }

    }
}
