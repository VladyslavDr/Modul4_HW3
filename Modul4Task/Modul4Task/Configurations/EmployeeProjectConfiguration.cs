using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4Task.Entities;

namespace Modul4Task.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeProjectId);

            builder.Property(p => p.EmployeeProjectId).HasColumnName("EmployeeProjectId").IsRequired();
            builder.Property(p => p.Rate).HasColumnName("Rate").HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasMaxLength(7).IsRequired();
        }
    }
}
