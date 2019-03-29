using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFirstAbp.CRM.SysRoles.Dto
{
    public class AddRolesIntput
    {
        [Required]
        public string Name { set; get; }

        public int[] Auth { set; get; }

    }
}
