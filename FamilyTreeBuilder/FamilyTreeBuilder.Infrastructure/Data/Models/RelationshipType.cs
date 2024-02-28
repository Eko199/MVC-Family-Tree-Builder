namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Constants.DataConstants.RelationshipType;

public class RelationshipType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Relationship> Relationships { get; set; } = new HashSet<Relationship>();
}