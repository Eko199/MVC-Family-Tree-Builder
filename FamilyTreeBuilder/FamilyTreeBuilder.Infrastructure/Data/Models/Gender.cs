namespace FamilyTreeBuilder.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Constants.DataConstants.Gender;

public class Gender
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Person> People { get; set; } = new HashSet<Person>();
}