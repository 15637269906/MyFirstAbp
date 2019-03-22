using MyFirstAbp.EntityFrameworkCore;

namespace MyFirstAbp.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyFirstAbpDbContext _context;

        public TestDataBuilder(MyFirstAbpDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}