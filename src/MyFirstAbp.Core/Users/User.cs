using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAbp.Users
{
   public  class User:Entity<int>
    {

        public String username { set; get; }
        public String password { set; get; }

        public String description { set; get; }
        public User() { }
        public User(String username,String password) {
            username = username;
            password = password;
        }


     


    }
}
