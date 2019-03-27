using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAbp.Users
{
   public  class User:Entity<int>
    {
        /// <summary>
        ///    用户名称
        /// </summary>
        public String username { set; get; }
        /// <summary>
        ///    用户密码
        /// </summary>
        public String password { set; get; }
        /// <summary>
        ///    描述
        /// </summary>
        public String description { set; get; }
        public User() { }
        public User(String Username,String Password) {
            username = Username;
            password = Password;
        }


     


    }
}
