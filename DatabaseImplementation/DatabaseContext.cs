using DatabaseImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseImplementation
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-82A8HG1\SQLEXPRESS;
                Initial Catalog=ExamDatabase;Integrated Security=True;
                MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Role> Roles { set; get; }
        public virtual DbSet<User> Users { set; get; }
    }
}
