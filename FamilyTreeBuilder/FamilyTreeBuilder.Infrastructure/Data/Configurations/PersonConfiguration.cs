namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder) 
        => builder.HasData(GetPeople());

    private static IEnumerable<Person> GetPeople()
    {
        var grandpa = new Person
        {
            Id = 4,
            FirstName = "Peter",
            LastName = "Ivanov",
            GenderId = 1,
            IsDeceased = true,
            Birthday = new DateTime(1920, 1, 1),
            DeathDate = new DateTime(2000, 1, 1)
        };

        var grandma = new Person
        {
            Id = 5,
            FirstName = "Maria",
            LastName = "Ivanova",
            GenderId = 2,
            IsDeceased = false
        };

        var father = new Person
        {
            Id = 2,
            FirstName = "Georgi",
            LastName = "Ivanov",
            GenderId = 1,
            IsDeceased = false,
            Birthday = new DateTime(1950, 1, 2),
            FatherId = grandpa.Id,
            MotherId = grandma.Id
        };

        var mother = new Person
        {
            Id = 3,
            FirstName = "Gergana",
            LastName = "Ivanova",
            GenderId = 2,
            IsDeceased = false,
            Birthday = new DateTime(1955, 1, 2)
        };

        var mainPerson = new Person
        {
            Id = 1,
            FirstName = "Ivan",
            LastName = "Ivanov",
            GenderId = 1,
            IsDeceased = false,
            Birthday = new DateTime(1980, 2, 2),
            Biography = "Default biography",
            FatherId = father.Id,
            MotherId = mother.Id
        };

        var brother = new Person
        {
            Id = 6,
            FirstName = "Ivancho",
            LastName = "Ivanov",
            GenderId = 1,
            IsDeceased = false,
            Birthday = new DateTime(1985, 2, 2),
            FatherId = father.Id,
            MotherId = mother.Id
        };

        var wife = new Person
        {
            Id = 7,
            FirstName = "Ivanka",
            LastName = "Ivanova",
            GenderId = 2,
            IsDeceased = false,
            Birthday = new DateTime(1982, 2, 23)
        };

        var daughter = new Person
        {
            Id = 8,
            FirstName = "Ivanka",
            LastName = "Ivanova",
            GenderId = 2,
            IsDeceased = false,
            Birthday = new DateTime(2012, 12, 31),
            FatherId = mainPerson.Id,
            MotherId = wife.Id
        };

        return new[] { grandpa, grandma, father, mother, mainPerson, brother, wife, daughter };
    }
}