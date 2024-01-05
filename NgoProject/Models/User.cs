﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoProject.Models;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPassword { get; set; }

    public string? UserAddress { get; set; }

    public string? UserAvatar { get; set; }

    public string? UserPhone { get; set; }

    public virtual ICollection<Donate> Donates { get; set; } = new List<Donate>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
}
