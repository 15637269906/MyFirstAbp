using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.CRM.Login.Dto
{
    public class LoginOutput
    {
        public int id { set; get; }
        public string name { set; get; }
        public int[] roles { set; get; }
        public int[] auths { set; get; }
        public int daysToExpire { set; get; }




    }
}
