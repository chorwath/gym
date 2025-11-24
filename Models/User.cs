using System;
using System.Collections.Generic;

namespace gym.Models;

/// <summary>
/// Table for users
/// </summary>
public partial class User
{
    public int UserID { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
