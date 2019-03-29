using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFirstAbp.UserInfos.Dto
{
    public class AddUserInfoOutput
    {
        [Required]
        public int id { set; get; }
        [Required]
        public string name { set; get; }
        public string email { set; get; }
        public string loginAccount { set; get; }
        public int[] roles { set; get; }
        public int status { set; get; }
        public AddUserInfoOutput(){}
    }
}
