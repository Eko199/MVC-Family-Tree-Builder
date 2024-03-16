namespace FamilyTreeBuilder.Core.Models;

/// <summary>
/// Model for visualization of person main stats
/// </summary>
public class PersonShortInfoViewModel
{
    /// <summary>
    /// Unique person identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Person first name
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Person family name
    /// </summary>
    public string LastName { get; set; } = string.Empty;
    
    /// <summary>
    /// Person gender
    /// </summary>
    public string Gender { get; set; } = null!;

    /// <summary>
    /// True if the person has died
    /// </summary>
    public bool IsDeceased { get; set; }

    /// <summary>
    /// Person's date of birth
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Person's date of death 
    /// </summary>
    public DateTime? DeathDate { get; set; }
    
    /// <summary>
    /// Person father short info
    /// </summary>
    public PersonShortInfoViewModel? Father { get; set; }
    
    /// <summary>
    /// Person mother short info
    /// </summary>
    public PersonShortInfoViewModel? Mother { get; set; }
    
    /// <summary>
    /// Person relationships
    /// </summary>
    public ICollection<RelationshipViewModel> Relationships { get; set; } = new HashSet<RelationshipViewModel>();
    
    /// <summary>
    /// Person children
    /// </summary>
    public ICollection<PersonShortInfoViewModel> Children { get; set; } = new HashSet<PersonShortInfoViewModel>();
}