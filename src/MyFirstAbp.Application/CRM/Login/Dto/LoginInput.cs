using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFirstAbp.CRM.Login.Dto
{
  public   class LoginInput
    {
        [Required]
        public string loginAccount { set; get; }

        [Required]
        public string loginPwd { set; get; }



    }
}
