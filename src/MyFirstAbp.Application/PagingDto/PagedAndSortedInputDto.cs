using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.PagingDto
{
    public class PagedAndSortedInputDto : PagedInputDto
    {

        public string Sorting;
        public PagedAndSortedInputDto() { }

        public PagedAndSortedInputDto(string Sorting) {
            Sorting = Sorting;
        }

    }
}
