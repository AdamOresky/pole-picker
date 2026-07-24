using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolePicker.Domain.Entities;

namespace PolePicker.Infrastructure.Persistence.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);

        builder.HasIndex(g => g.Uuid).IsUnique();

        builder.Property(g => g.Name)
            .IsRequired();

        builder.Property(g => g.InviteCode)
            .IsRequired();

        builder.HasIndex(g => g.InviteCode).IsUnique();
    }
}