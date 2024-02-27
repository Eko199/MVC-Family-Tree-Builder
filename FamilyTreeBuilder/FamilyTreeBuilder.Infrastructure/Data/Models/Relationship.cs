namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Relationship
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int TypeId { get; set; }

    [ForeignKey(nameof(TypeId))]
    public RelationshipType Type { get; set; } = null!;

    [Required]
    public int Person1Id { get; set; }

    [ForeignKey(nameof(Person1Id))]
    public Person Person1 { get; set; } = null!;

    [Required]
    public int Person2Id { get; set; }

    [ForeignKey(nameof(Person2Id))]
    public Person Person2 { get; set; } = null!;

    public DateTime? Date { get; set; }
}