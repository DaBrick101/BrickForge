namespace BrickForge.Data
{

    using Microsoft.EntityFrameworkCore;
    using BrickForge.Models;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
