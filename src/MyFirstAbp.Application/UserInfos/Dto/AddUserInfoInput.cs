using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserInfos.Dto
{
    public class AddUserInfoInput
    {

        public int status { set; get; }
        public string name { set; get; }
        public string email { set; get; }
        public string loginAccount { set; get; }
        public int[] roles{ set; get; }
        public AddUserInfoInput() { }


    }
}
