#pragma warning disable CS8618 //#4


using System.ComponentModel.DataAnnotations;  //#4



namespace User2.Models;

public class LogUser
{

    //Email
    [Required(ErrorMessage = "Email is required.")]
    [Display(Name= "Email")]
    [EmailAddress(ErrorMessage = "Invalid Email format.")]
    public string LogEmail { get; set; }


    //Password
    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [Display(Name= "Password")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
    public string LogPassword { get; set; }
}