using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MimirBlog.Models;

namespace MimirBlog.Data.EntityTypeConfigurations{
    public class TagConfiguration :IEntityTypeConfiguration<Tag>{
        public void Configure(EntityTypeBuilder<Tag> builder){
            builder.ToTable("Tag");

            builder.Property(t => t.Description)
                .HasMaxLength(50);
        }
    }
}