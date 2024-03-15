namespace FamilyTreeBuilder.Core.Models;

using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

/// <summary>
/// Model for relationship type visualization
/// </summary>
public class RelationshipTypeViewModel
{
    /// <summary>
    /// Unique relationship type identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Relationship type name
    /// </summary>
    [Required]
    [StringLength(RelationshipType.NameMaxLength, MinimumLength = RelationshipType.NameMinLength, ErrorMessage = StringLengthErrorMessage)]
    public string Name { get; set; } = string.Empty;
}