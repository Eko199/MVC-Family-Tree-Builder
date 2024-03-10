namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class RelationshipTypeConfiguration : IEntityTypeConfiguration<RelationshipType>
{
    public void Configure(EntityTypeBuilder<RelationshipType> builder)
    {
        var relationshipTypes = new[]
        {
            new RelationshipType
            {
                Id = 1,
                Name = "Married"
            },
            new RelationshipType
            {
                Id = 2,
                Name = "Divorced"
            },
            new RelationshipType
            {
                Id = 3,
                Name = "Partners"
            }
        };

        builder.HasData(relationshipTypes);
    }
}