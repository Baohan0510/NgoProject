using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string? CategoryName { get; set; }
    [Required]
    public string? CategoryDescription { get; set; }

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
