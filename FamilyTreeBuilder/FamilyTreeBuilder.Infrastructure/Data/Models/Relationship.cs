namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Comment("Relationship between two people")]
public class Relationship
{
    [Key]
    [Comment("Unique relationship identifier")]
    public int Id { get; set; }

    [Required]
    [Comment("Identifier of relationship type")]
    public int TypeId { get; set; }

    [ForeignKey(nameof(TypeId))]
    public RelationshipType Type { get; set; } = null!;

    [Required]
    [Comment("Identifier of first person in relationship")]
    public int Person1Id { get; set; }

    [ForeignKey(nameof(Person1Id))]
    public Person Person1 { get; set; } = null!;

    [Required]
    [Comment("Identifier of second person in relationship")]
    public int Person2Id { get; set; }

    [ForeignKey(nameof(Person2Id))]
    public Person Person2 { get; set; } = null!;

    [Comment("Date and time of relationship start")]
    public DateTime? Start { get; set; }
}