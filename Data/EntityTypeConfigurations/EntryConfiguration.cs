using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MimirBlog.Models;

namespace MimirBlog.Data.EntityTypeConfigurations{
    public class EntryConfiguration : IEntityTypeConfiguration<Entry>{
        public void Configure(EntityTypeBuilder<Entry> builder){
            #region Configuration
            builder.ToTable("Entry");
            #endregion

            #region Properties
            builder.Property(e => e.Title)
                .HasMaxLength(100);
            builder.Property(e => e.Text)
                .HasMaxLength(8000);
            #endregion

            #region Relationships

            

            #endregion
        }
    }
}