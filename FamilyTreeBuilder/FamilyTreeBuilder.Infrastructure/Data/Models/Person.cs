namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Constants.DataConstants.Person;

public class Person
{
    [Key]
    [Comment("Unique person identifier")]
    public int Id { get; set; }

    [Required]
    [MaxLength(FirstNameMaxLength)]
    [Comment("Person first name")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(LastNameMaxLength)]
    [Comment("Person last name")]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [Comment("Identifier of gender entity")]
    public int GenderId { get; set; }

    [ForeignKey(nameof(GenderId))]
    public Gender Gender { get; set; } = null!;

    [Required]
    [Comment("True if the person has died")]
    public bool IsDeceased { get; set; }

    [Comment("Person's date of birth")]
    public DateTime? Birthday { get; set; }

    [Comment("Person's date of death")]
    public DateTime? DeathDate { get; set; }

    [MaxLength(BiographyMaxLength)]
    [Comment("Person biography")]
    public string? Biography { get; set; }

    [Comment("Identifier of father's entity")]
    public int? FatherId { get; set; }

    [ForeignKey(nameof(FatherId))]
    public Person? Father { get; set; }

    [Comment("Identifier of mother's entity")]
    public int? MotherId { get; set; }

    [ForeignKey(nameof(MotherId))]
    public Person? Mother { get; set; }

    [NotMapped]
    public ICollection<Relationship> Relationships { get; set; } = new HashSet<Relationship>();

    [NotMapped]
    public ICollection<Person> Children { get; set; } = new HashSet<Person>();

    public ICollection<Fact> Facts { get; set; } = new HashSet<Fact>();
}