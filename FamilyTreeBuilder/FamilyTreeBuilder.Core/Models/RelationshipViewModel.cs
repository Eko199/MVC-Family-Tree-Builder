namespace FamilyTreeBuilder.Core.Models;

/// <summary>
/// Model for short relationship visualization
/// </summary>
public class RelationshipViewModel
{
    /// <summary>
    /// Relationship type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// First person in relationship
    /// </summary>
    public PersonShortInfoViewModel Person1 { get; set; } = null!;

    /// <summary>
    /// Second person in relationship
    /// </summary>
    public PersonShortInfoViewModel Person2 { get; set; } = null!;
}