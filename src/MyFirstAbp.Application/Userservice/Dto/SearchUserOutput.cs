using MyFirstAbp.Userservice.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Userservice.Dto
{
   public  class SearchUserOutput
    {
        public List<UserDto> User { get; set; }
    }
}
