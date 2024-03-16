namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Constants.DataConstants.Fact;

[Comment("Person fact")]
public class Fact
{
    [Key]
    [Comment("Unique fact identifier")]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    [Comment("Fact title")]
    public string Title { get; set; } = string.Empty;

    [MaxLength(DescriptionMaxLength)]
    [Comment("Fact description")]
    public string? Description { get; set; } = string.Empty;

    [Comment("Date of fact")]
    public DateTime? Date { get; set; }

    [Required]
    [Comment("Identifier of fact's person")]
    public int PersonId { get; set; }

    [ForeignKey(nameof(PersonId))]
    public Person Person { get; set; } = null!;
}