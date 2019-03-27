using Abp.Domain.Entities;
using MyFirstAbp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFirstAbp.Roles
{
    public class Role : Entity<int>
    {
        /// <summary>
        ///     用户id
        /// </summary>
        [ForeignKey("userId")]
        public virtual User User { get; set; }
        public virtual int userId { get; set; }
        /// <summary>
        ///    角色名称
        /// </summary>
        
        [Required]
        public String rolename { set; get; }




    }
}
