namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Constants.DataConstants.Fact;

public class Fact
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; } = string.Empty;

    public DateTime? Date { get; set; }

    [Required]
    public int PersonId { get; set; }

    [ForeignKey(nameof(PersonId))]
    public Person Person { get; set; } = null!;
}