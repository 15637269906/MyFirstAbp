using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Auths.Dto
{

    [AutoMap(typeof(Pmgt.Auths.Auth))]
    public class GetAllAuthsDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }
        public string Title { set; get; }
        public GetAllAuthsDto[] children { set; get; }
        public GetAllAuthsDto() { }
    }
}
