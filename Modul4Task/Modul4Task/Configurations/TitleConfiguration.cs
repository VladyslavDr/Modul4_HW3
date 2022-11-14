using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4Task.Entities;

namespace Modul4Task.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.TitleId);

            builder.Property(p => p.TitleId).HasColumnName("Title").IsRequired();
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
        }
    }
}
