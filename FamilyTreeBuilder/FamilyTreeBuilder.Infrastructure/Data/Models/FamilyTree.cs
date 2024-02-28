namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using static Constants.DataConstants.FamilyTree;

public class FamilyTree
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

    [Required] 
    public string OwnerId { get; set; } = string.Empty;

    [ForeignKey(nameof(OwnerId))]
    public IdentityUser Owner { get; set; } = null!;

    [Required]
    public int MainPersonId { get; set; }

    [ForeignKey(nameof(MainPersonId))]
    public Person MainPerson { get; set; } = null!;
}