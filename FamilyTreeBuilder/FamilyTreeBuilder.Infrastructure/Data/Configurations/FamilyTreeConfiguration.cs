namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class FamilyTreeConfiguration : IEntityTypeConfiguration<FamilyTree>
{
    public void Configure(EntityTypeBuilder<FamilyTree> builder) 
        => builder.HasData(new FamilyTree
        {
            Id = 1,
            Title = "Test Tree",
            Description = "Default description",
            OwnerId = UserConfiguration.TestUser1.Id,
            MainPersonId = 1
        });
}