using System;
using System.Collections.Generic;

namespace mymvcapp.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public decimal Amount { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Subscription { get; set; } = null!;

    public int? Phone { get; set; }
}
