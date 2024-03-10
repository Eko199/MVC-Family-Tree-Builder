namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class GenderConfiguration : IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        var genders = new[]
        {
            new Gender
            {
                Id = 1,
                Name = "male"
            },
            new Gender
            {
                Id = 2,
                Name = "female"
            }
        };

        builder.HasData(genders);
    }
}