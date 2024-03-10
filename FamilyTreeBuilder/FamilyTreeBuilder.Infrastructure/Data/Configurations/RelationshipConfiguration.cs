namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class RelationshipConfiguration : IEntityTypeConfiguration<Relationship>
{
    public void Configure(EntityTypeBuilder<Relationship> builder)
    {
        builder.HasOne(r => r.Person1)
            .WithMany(p => p.Relationships)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Relationship
            {
                Id = 1,
                Person1Id = 4,
                Person2Id = 5,
                TypeId = 1,
                Start = new DateTime(1949, 12, 12)
            },
            new Relationship
            {
                Id = 2,
                Person1Id = 2,
                Person2Id = 3,
                TypeId = 2
            });
    }
}