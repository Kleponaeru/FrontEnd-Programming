
using System.ComponentModel.DataAnnotations;
namespace Models;
public class RegisterModel
{
    [Required(ErrorMessage = "Username is required.")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Nomor Telepon is required.")]
    [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Nomor Telepon must be a valid number with 10-15 digits.")]
    public string? NoTelp { get; set; }

    [Required(ErrorMessage = "Register As is required.")]
    public string? RegisterAs { get; set; }
}


