using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.PagingDto
{
   public  class PagedInputDto
    {

        public int MaxResultCount;
        public int SkipCount;

        public PagedInputDto() {
        }
        public PagedInputDto(int MaxResultCount, int SkipCount) {
            MaxResultCount = MaxResultCount;
            SkipCount = SkipCount;
        }
      


    }
}
