using System.ComponentModel.DataAnnotations;

namespace FamilyTreeBuilder.Infrastructure.Data.Models;

public class Gender
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public ICollection<Person> People { get; set; } = new HashSet<Person>();
}