namespace FamilyTreeBuilder.Core.Models;

using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

/// <summary>
/// Model for gender visualization
/// </summary>
public class GenderViewModel
{
    /// <summary>
    /// Unique gender identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gender name
    /// </summary>
    [Required]
    [StringLength(Gender.NameMaxLength, MinimumLength = Gender.NameMaxLength, ErrorMessage = StringLengthErrorMessage)]
    public string Name { get; set; } = string.Empty;
}