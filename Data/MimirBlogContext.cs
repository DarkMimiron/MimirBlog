using Microsoft.EntityFrameworkCore;
using MimirBlog.Data.EntityTypeConfigurations;
using MimirBlog.Models;

namespace MimirBlog.Data{
    public class MimirBlogContext : DbContext{
        public Entry Entries{ get; set; }
        public Tag Tags{ get; set; }

        public MimirBlogContext(DbContextOptions options)
        : base(options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new EntryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new EntryTagConfiguration());
        }
    }
}