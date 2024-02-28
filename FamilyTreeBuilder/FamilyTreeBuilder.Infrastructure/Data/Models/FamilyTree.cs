namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Constants.DataConstants.FamilyTree;

public class FamilyTree
{
    [Key]
    [Comment("Unique family tree identifier")]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    [Comment("Family tree name")]
    public string Title { get; set; } = string.Empty;

    [MaxLength(DescriptionMaxLength)]
    [Comment("Family tree description")]
    public string? Description { get; set; }

    [Required]
    [Comment("Identifier of the user who owns the tree (usually the creator)")]
    public string OwnerId { get; set; } = string.Empty;

    [ForeignKey(nameof(OwnerId))]
    public IdentityUser Owner { get; set; } = null!;

    [Required]
    [Comment("Identifier of the main person of the tree")]
    public int MainPersonId { get; set; }

    [ForeignKey(nameof(MainPersonId))]
    public Person MainPerson { get; set; } = null!;
}