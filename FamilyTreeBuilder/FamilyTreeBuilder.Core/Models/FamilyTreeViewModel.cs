namespace FamilyTreeBuilder.Core.Models;

/// <summary>
/// Model for family tree visualization
/// </summary>
public class FamilyTreeViewModel
{
    /// <summary>
    /// Unique family tree identifier
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Family tree title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Identifier of the user who owns the tree (usually the creator)
    /// </summary>
    public string OwnerId { get; set; } = string.Empty;

    /// <summary>
    /// Main person of the tree
    /// </summary>
    public PersonShortInfoViewModel MainPerson { get; set; } = null!;
}