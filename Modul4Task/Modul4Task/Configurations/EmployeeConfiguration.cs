using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4Task.Entities;

namespace Modul4Task.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);

            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").IsRequired();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.HiredData).HasColumnName("HiredData").HasMaxLength(7).IsRequired();
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").ValueGeneratedNever().IsRequired();
            builder.Property(p => p.TitleId).HasColumnName("TitleId").ValueGeneratedNever().IsRequired();
            builder.HasOne(d => d.Office)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Title)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
