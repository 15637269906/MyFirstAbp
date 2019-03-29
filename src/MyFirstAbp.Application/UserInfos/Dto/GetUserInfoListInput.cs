using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserInfos.Dto
{
   public class GetUserInfoListInput
    {
        public int status { set; get; }
            public int page { set; get; }
        public int pageCount { set; get; }
        public int roleid { set; get; }
        public string key { set; get; }


    }
}
