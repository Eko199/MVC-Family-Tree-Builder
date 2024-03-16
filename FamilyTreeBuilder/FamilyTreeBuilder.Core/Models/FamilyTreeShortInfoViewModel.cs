namespace FamilyTreeBuilder.Core.Models;

/// <summary>
/// Model for family tree card visualization
/// </summary>
public class FamilyTreeShortInfoViewModel
{
    /// <summary>
    /// Unique family tree identifier
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Family tree name
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Family tree description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Identifier of the user who owns the tree (usually the creator)
    /// </summary>
    public string OwnerId { get; set; } = string.Empty;
}