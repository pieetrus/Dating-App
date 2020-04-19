using DattingAPP.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DattingAPP.API.Data
{
    public class DataContext : DbContext
    {
        // public DataContext(DbContextOptions<DbContext> options) : base(options)
        // {

        // }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=DatingApp.db");
        }
           

        public DbSet<Value> Values { get; set; }

    }
}