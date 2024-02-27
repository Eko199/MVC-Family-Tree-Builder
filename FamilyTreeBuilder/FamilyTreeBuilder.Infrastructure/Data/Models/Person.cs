namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Person
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required] 
    public string LastName { get; set; } = string.Empty;

    [Required]
    public int GenderId { get; set; }

    [ForeignKey(nameof(Gender))]
    public Gender Gender { get; set; } = null!;

    [Required]
    public bool IsDeceased { get; set; }

    public DateTime? Birthday { get; set; }

    public DateTime? DeathDate { get; set; }

    public string? Biography { get; set; }

    public int? FatherId { get; set; }

    [ForeignKey(nameof(FatherId))]
    public Person? Father { get; set; }

    public int? MotherId { get; set; }

    [ForeignKey(nameof(MotherId))]
    public Person? Mother { get; set; }

    public ICollection<Relationship> Relationships { get; set; } = new HashSet<Relationship>();

    public ICollection<Person> Children { get; set; } = new HashSet<Person>();

    public ICollection<Fact> Facts { get; set; } = new HashSet<Fact>();
}