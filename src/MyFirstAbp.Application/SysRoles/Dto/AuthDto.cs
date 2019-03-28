using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.SysRoles.Dto
{

    [AutoMap(typeof(Auths.Auth))]
    public  class AuthDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }

    }
}
