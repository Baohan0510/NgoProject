using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class Ourpartner
{
    [Key]
    public int OurpartnerId { get; set; }
    [Required]
    public string? OurpartnerName { get; set; }
    [Required]
    public string? OurpartnerAddress { get; set; }
    [Required]
    public string? OurpartnerLogo { get; set; }
    [Required]
    public string? OurpartnerPhone { get; set; }
    [Required]
    public string? OurpartnerAddressWeb { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "The email address entered is invalid.")]
    public string? OurpartnerMail { get; set; }

  public virtual ICollection<News> News { get; set; } = new List<News>();
}
