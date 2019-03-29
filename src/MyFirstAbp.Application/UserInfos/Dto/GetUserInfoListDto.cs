
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserInfos.Dto
{
    [AutoMap(typeof(Pmgt.UserInfos.UserInfo))]
    public class GetUserInfoListDto
    {
        public int Id { set; get; }
            public string Name { set; get; }
        public string Email { set; get; }
        public int LoginAccount { set; get; }
        public DateTime LastLoginDate { set; get; }
        public int[] Roles { set; get; }
        public int Status { set; get; }
        public GetUserInfoListDto() { }

    }
}
