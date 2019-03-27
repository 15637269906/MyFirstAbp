using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Users.Dto
{
    [AutoMap(typeof(Users.User))]
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
