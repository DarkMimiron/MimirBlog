using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MimirBlog.Models;

namespace MimirBlog.Data.EntityTypeConfigurations{
    public class EntryTagConfiguration : IEntityTypeConfiguration<EntryTag>{
        public void Configure(EntityTypeBuilder<EntryTag> builder){
            #region Configurations
            builder.ToTable("EntryTag");

            builder.HasKey(et => new {et.EntryId, et.TagId});
            #endregion

            #region Properties
            #endregion
            
            #region Relationships
            builder.HasOne(et => et.Entry)
                .WithMany(et => et.EntryTags)
                .HasForeignKey(et => et.EntryId);
            builder.HasOne(et => et.Tag)
                .WithMany(et => et.EntryTags)
                .HasForeignKey(et => et.TagId);
            #endregion
        }
    }
}