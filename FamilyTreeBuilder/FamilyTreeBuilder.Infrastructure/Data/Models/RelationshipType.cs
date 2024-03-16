namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Constants.DataConstants.RelationshipType;

[Comment("Type of relationship between two people")]
public class RelationshipType
{
    [Key]
    [Comment("Unique relationship type identifier")]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    [Comment("Relationship type name")]
    public string Name { get; set; } = string.Empty;

    public ICollection<Relationship> Relationships { get; set; } = new HashSet<Relationship>();
}