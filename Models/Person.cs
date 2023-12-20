using System;
using System.Collections.Generic;

namespace Azure02.Models;

public partial class Person
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string FirstName { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }
}
