using System.ComponentModel.DataAnnotations;

namespace MyMVC.Models;

public class People
{
    public int Id { get; set; }
    [Required(ErrorMessage = "This field is required!")] public string Name { get; set; }
    [Required(ErrorMessage = "This field is required!")] public int Age { get; set; }
    [Required(ErrorMessage = "This field is required!")] public string Role { get; set; }
    public string? Email { get; set; }
}
