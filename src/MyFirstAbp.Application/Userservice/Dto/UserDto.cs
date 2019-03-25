using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Userservice.Dto
{
    public class UserDto : EntityDto
    {
        public string username { get; set; }
        public string description { get; set; }

       

        public override string ToString()
        {
            return string.Format("User Id={0},username={1},description={2}", Id,username, description);
        }


    }

}
