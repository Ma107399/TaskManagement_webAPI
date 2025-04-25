using Microsoft.EntityFrameworkCore;
using TaskManagementAPIZimozi.Model;
namespace TaskManagementAPIZimozi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }
        public DbSet<TaskItemModel> TaskItems { get; set; }

    }
    
       
}
