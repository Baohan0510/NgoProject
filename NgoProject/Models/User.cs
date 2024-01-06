using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string? UserName { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "The email address entered is invalid.")]
    public string? UserEmail { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? UserPassword { get; set; }
    [Required]
    public string? UserAddress { get; set; }
    [Required]
    public string? UserAvatar { get; set; }
    [Required]
    public string? UserPhone { get; set; }

    public virtual ICollection<Donate> Donates { get; set; } = new List<Donate>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
}
