using Microsoft.EntityFrameworkCore;

namespace Task_Try_Out_Forum.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> users {get;set;}
        public DbSet<Thread> threads {get;set;}
        public DbSet<Comment> comments {get;set;}
        public AppDBContext (DbContextOptions options):base(options)
        {
            
        }
        
    }
}