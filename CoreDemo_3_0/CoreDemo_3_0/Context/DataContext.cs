using Microsoft.EntityFrameworkCore;

namespace CoreDemo_3_0.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }


}