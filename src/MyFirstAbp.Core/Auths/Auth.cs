using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Auths
{
  public  class Auth:Entity<int>
    {
        //权限编号
        public string Code { get; set; }
        //权限描述
        public string Description { get; set; }
        //权限名称
        public string Name { get; set; }
        //上一级权限的id
        public int ParentId { get; set; }
        //标题
        public string Title { get; set; }
        public Auth() { }


    }
}
