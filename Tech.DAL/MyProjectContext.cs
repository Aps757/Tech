using Microsoft.EntityFrameworkCore;

namespace Tech.DAL
{
    public class MyProjectContext:DbContext
    {
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options) 
        { 
        }
        public DbSet<Employee>  Employees { get; set; }
    }
}
