using Abp.AspNetCore.Mvc.Views;

namespace MyFirstAbp.Web.Views
{
    public abstract class MyFirstAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyFirstAbpRazorPage()
        {
            LocalizationSourceName = MyFirstAbpConsts.LocalizationSourceName;
        }
    }
}
