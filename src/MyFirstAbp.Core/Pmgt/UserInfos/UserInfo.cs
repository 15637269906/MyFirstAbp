using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Pmgt.UserInfos
{
   public  class UserInfo:Entity<int>
    {
        //用户描述
        public string Description { get; set; }
        //邮箱
        public string Email { get; set; }
        //
        public string LoginAccount { get; set; }
        //登录密码的MD5
        public string  LoginPwd { get; set; }
        //手机号
        public string Mobile { get; set; }
        //用户名
        public string Name { get; set; }
        //上次密码修改时间
        public DateTime    PassModifyTime { get; set; }
        //员工id
        public  string Staffld { get; set; }
        //状态 1--有效  10--冻结 20--无效
        public int Status { get; set; }

        public UserInfo() { }


    }
}
