namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Constants.DataConstants.Gender;

public class Gender
{
    [Key]
    [Comment("Unique gender identifier")]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    [Comment("Gender name")]
    public string Name { get; set; } = string.Empty;

    public ICollection<Person> People { get; set; } = new HashSet<Person>();
}