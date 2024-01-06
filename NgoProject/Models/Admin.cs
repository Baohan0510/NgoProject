using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class Admin
{
    [Key]
    public int AdminId { get; set; }
    [Required]
    public string? AdminName { get; set; }
    [Required]
    public string? AdminAvatar { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "The email address entered is invalid.")]
    public string? AdminEmail { get; set; }
    [Required]
    public string? AdminAddress { get; set; }
    [Required]
    public string? AdminPhone { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? AdminPassword { get; set; }
}
