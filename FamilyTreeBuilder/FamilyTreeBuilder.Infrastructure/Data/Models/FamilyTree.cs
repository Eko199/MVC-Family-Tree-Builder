namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

public class FamilyTree
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

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