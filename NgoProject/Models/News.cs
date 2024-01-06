using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class News
{
    [Key]
    public int NewsId { get; set; }
    [Required]
    public string? NewsName { get; set; }
    [Required]
    public string? NewsImage1 { get; set; }
    [Required]
    public string? NewsContent { get; set; }
    [Required]
    public string? NewsDescription { get; set; }

    public int? CategoryId { get; set; }

    public int? OurpartnerId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Donate> Donates { get; set; } = new List<Donate>();

    public virtual Ourpartner? Ourpartner { get; set; }
}
