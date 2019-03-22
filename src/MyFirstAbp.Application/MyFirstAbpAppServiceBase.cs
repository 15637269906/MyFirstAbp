using Abp.Application.Services;

namespace MyFirstAbp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyFirstAbpAppServiceBase : ApplicationService
    {
        protected MyFirstAbpAppServiceBase()
        {
            LocalizationSourceName = MyFirstAbpConsts.LocalizationSourceName;
        }
    }
}