using System;
using System.Collections.Generic;

namespace bookStore.Domain.Entities;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
