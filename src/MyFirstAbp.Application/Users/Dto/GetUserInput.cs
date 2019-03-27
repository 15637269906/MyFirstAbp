using MyFirstAbp.PagingDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Users.Dto
{
    public class GetUserInput : PagedSortedAndFilteredInputDto
    {

        public String username { set; get; }
        public String description { set; get; }


    }
}
