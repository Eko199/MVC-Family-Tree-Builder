namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class FactConfiguration : IEntityTypeConfiguration<Fact>
{
    public void Configure(EntityTypeBuilder<Fact> builder)
    {
        builder.HasData(
            new Fact
            {
                Id = 1,
                PersonId = 1,
                Title = "Test fact",
                Date = new DateTime(1985, 1, 1),
                Description = "This is a test fact"
            },
            new Fact
            {
                Id = 2,
                PersonId = 8,
                Title = "Education",
                Date = new DateTime(2019, 9, 15),
                Description = "Primary education"
            });
    }
}