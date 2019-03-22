using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFirstAbp
{
  public  class Author : Entity<int>
    {
        public string Name { set; get; }

        public virtual ICollection<Blog> Blogs { set; get; }


    }

    public class Blog:Entity<int>
    {
        public string Title { set; get; }
        public DateTime Time { set; get; }

        [ForeignKey("Author")]
        public int AuthorId { set; get; }
        public virtual Author Author { set; get; }
    }
  




}
