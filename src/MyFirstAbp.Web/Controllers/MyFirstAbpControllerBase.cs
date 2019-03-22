using Abp.AspNetCore.Mvc.Controllers;

namespace MyFirstAbp.Web.Controllers
{
    public abstract class MyFirstAbpControllerBase: AbpController
    {
        protected MyFirstAbpControllerBase()
        {
            LocalizationSourceName = MyFirstAbpConsts.LocalizationSourceName;
        }
    }
}