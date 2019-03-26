using MyFirstAbp.PagingDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Userservice.Dto
{
    public class GetUserInput : PagedSortedAndFilteredInputDto
    {

        public String username { set; get; }
        public String description { set; get; }


    }
}
