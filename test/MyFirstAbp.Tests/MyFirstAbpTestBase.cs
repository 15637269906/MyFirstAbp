using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyFirstAbp.EntityFrameworkCore;
using MyFirstAbp.Tests.TestDatas;

namespace MyFirstAbp.Tests
{
    public class MyFirstAbpTestBase : AbpIntegratedTestBase<MyFirstAbpTestModule>
    {
        public MyFirstAbpTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyFirstAbpDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyFirstAbpDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyFirstAbpDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyFirstAbpDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyFirstAbpDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyFirstAbpDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyFirstAbpDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyFirstAbpDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
