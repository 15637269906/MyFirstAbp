using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Student
{
    public  class Students:Entity<int>
    {
        public string aa { get; set; }
        public string bb { get; set; }

        public Students() { }
        public Students(String aa1, String bb1) {
            aa = aa1;
            bb = bb1;
        }

        

    }
}
