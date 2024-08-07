using System;
using System.Collections.Generic;

namespace mymvcapp.Models;

public partial class UserRegistration
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ConfirmPassword { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }
}
